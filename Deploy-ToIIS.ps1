# =====================================================
# Deploy ASP.NET Core Application to IIS
# =====================================================
# This script automates the deployment of the Word Manipulation application to IIS
# Run as Administrator

param(
	[Parameter(Mandatory=$false)]
	[string]$SiteName = "WordManipulation",

	[Parameter(Mandatory=$false)]
	[string]$AppPoolName = "WordManipulationAppPool",

	[Parameter(Mandatory=$false)]
	[string]$PhysicalPath = "C:\inetpub\wwwroot\WordManipulation",

	[Parameter(Mandatory=$false)]
	[int]$Port = 8080,

	[Parameter(Mandatory=$false)]
	[string]$HostName = "",

	[Parameter(Mandatory=$false)]
	[string]$DatabaseServer = "localhost",

	[Parameter(Mandatory=$false)]
	[string]$DatabaseName = "WordManipulationDb",

	[Parameter(Mandatory=$false)]
	[string]$DatabaseUser = "postgres",

	[Parameter(Mandatory=$false)]
	[string]$DatabasePassword = "pwd"
)

# Check if running as Administrator
$currentPrincipal = New-Object Security.Principal.WindowsPrincipal([Security.Principal.WindowsIdentity]::GetCurrent())
$isAdmin = $currentPrincipal.IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)

if (-not $isAdmin) {
	Write-Error "This script must be run as Administrator!"
	exit 1
}

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Word Manipulation IIS Deployment Script" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Step 1: Install IIS and required features
Write-Host "[Step 1] Installing IIS and required features..." -ForegroundColor Yellow

$iisFeatures = @(
	"IIS-WebServerRole",
	"IIS-WebServer",
	"IIS-CommonHttpFeatures",
	"IIS-HttpErrors",
	"IIS-HttpRedirect",
	"IIS-ApplicationDevelopment",
	"IIS-NetFxExtensibility45",
	"IIS-HealthAndDiagnostics",
	"IIS-HttpLogging",
	"IIS-LoggingLibraries",
	"IIS-RequestMonitor",
	"IIS-HttpTracing",
	"IIS-Security",
	"IIS-RequestFiltering",
	"IIS-Performance",
	"IIS-WebServerManagementTools",
	"IIS-IIS6ManagementCompatibility",
	"IIS-Metabase",
	"IIS-ManagementConsole",
	"IIS-BasicAuthentication",
	"IIS-WindowsAuthentication",
	"IIS-StaticContent",
	"IIS-DefaultDocument",
	"IIS-DirectoryBrowsing",
	"IIS-ISAPIExtensions",
	"IIS-ISAPIFilter",
	"IIS-HttpCompressionStatic",
	"IIS-ASPNET45"
)

foreach ($feature in $iisFeatures) {
	$installed = Get-WindowsOptionalFeature -Online -FeatureName $feature -ErrorAction SilentlyContinue
	if ($installed -and $installed.State -eq "Enabled") {
		Write-Host "  ✓ $feature already installed" -ForegroundColor Green
	} else {
		Write-Host "  Installing $feature..." -ForegroundColor Gray
		Enable-WindowsOptionalFeature -Online -FeatureName $feature -All -NoRestart -ErrorAction Stop | Out-Null
		Write-Host "  ✓ $feature installed" -ForegroundColor Green
	}
}

# Step 2: Install ASP.NET Core Hosting Bundle
Write-Host ""
Write-Host "[Step 2] Checking ASP.NET Core Hosting Bundle..." -ForegroundColor Yellow

$hostingBundleInstalled = Get-ItemProperty "HKLM:\SOFTWARE\dotnet\Setup\InstalledVersions\x64\sharedhost" -ErrorAction SilentlyContinue

if (-not $hostingBundleInstalled) {
	Write-Host "  ASP.NET Core Hosting Bundle not found!" -ForegroundColor Red
	Write-Host "  Please download and install from:" -ForegroundColor Yellow
	Write-Host "  https://dotnet.microsoft.com/download/dotnet/8.0" -ForegroundColor Cyan
	Write-Host "  Look for: ASP.NET Core Runtime 8.0.x Hosting Bundle" -ForegroundColor Cyan
	Write-Host ""
	$continue = Read-Host "Have you installed the Hosting Bundle? (Y/N)"
	if ($continue -ne "Y" -and $continue -ne "y") {
		Write-Host "Please install the Hosting Bundle and re-run this script." -ForegroundColor Red
		exit 1
	}
} else {
	Write-Host "  ✓ ASP.NET Core Hosting Bundle is installed" -ForegroundColor Green
}

# Step 3: Import IIS Module
Write-Host ""
Write-Host "[Step 3] Loading IIS module..." -ForegroundColor Yellow
Import-Module WebAdministration -ErrorAction Stop
Write-Host "  ✓ IIS module loaded" -ForegroundColor Green

# Step 4: Create Application Pool
Write-Host ""
Write-Host "[Step 4] Configuring Application Pool..." -ForegroundColor Yellow

if (Test-Path "IIS:\AppPools\$AppPoolName") {
	Write-Host "  Application pool '$AppPoolName' already exists" -ForegroundColor Gray
	Remove-WebAppPool -Name $AppPoolName -ErrorAction SilentlyContinue
	Start-Sleep -Seconds 2
}

New-WebAppPool -Name $AppPoolName -Force | Out-Null
Set-ItemProperty "IIS:\AppPools\$AppPoolName" -Name "managedRuntimeVersion" -Value ""
Set-ItemProperty "IIS:\AppPools\$AppPoolName" -Name "startMode" -Value "AlwaysRunning"
Set-ItemProperty "IIS:\AppPools\$AppPoolName" -Name "processModel.idleTimeout" -Value "00:00:00"
Set-ItemProperty "IIS:\AppPools\$AppPoolName" -Name "recycling.periodicRestart.time" -Value "00:00:00"

Write-Host "  ✓ Application pool '$AppPoolName' created" -ForegroundColor Green

# Step 5: Publish the application
Write-Host ""
Write-Host "[Step 5] Publishing application..." -ForegroundColor Yellow

$projectPath = Join-Path $PSScriptRoot "WordManipulationDotNet7\WordManipulationDotNet7.csproj"
$publishPath = Join-Path $PSScriptRoot "publish"

if (-not (Test-Path $projectPath)) {
	Write-Error "Project file not found: $projectPath"
	exit 1
}

# Clean previous publish
if (Test-Path $publishPath) {
	Remove-Item -Path $publishPath -Recurse -Force
}

# Publish the application
dotnet publish $projectPath `
	--configuration Release `
	--output $publishPath `
	--runtime win-x64 `
	--self-contained false `
	/p:EnvironmentName=Production

if ($LASTEXITCODE -ne 0) {
	Write-Error "Failed to publish application"
	exit 1
}

Write-Host "  ✓ Application published to: $publishPath" -ForegroundColor Green

# Step 6: Create physical directory and copy files
Write-Host ""
Write-Host "[Step 6] Deploying application files..." -ForegroundColor Yellow

if (-not (Test-Path $PhysicalPath)) {
	New-Item -Path $PhysicalPath -ItemType Directory -Force | Out-Null
	Write-Host "  ✓ Created directory: $PhysicalPath" -ForegroundColor Green
} else {
	Write-Host "  Directory already exists: $PhysicalPath" -ForegroundColor Gray
	# Stop the site if it exists to allow file copy
	if (Get-Website -Name $SiteName -ErrorAction SilentlyContinue) {
		Stop-Website -Name $SiteName -ErrorAction SilentlyContinue
		Start-Sleep -Seconds 2
	}
	# Clean existing files
	Get-ChildItem -Path $PhysicalPath -Recurse | Remove-Item -Force -Recurse -ErrorAction SilentlyContinue
}

# Copy published files
Copy-Item -Path "$publishPath\*" -Destination $PhysicalPath -Recurse -Force
Write-Host "  ✓ Application files deployed" -ForegroundColor Green

# Step 7: Update appsettings.json with database connection
Write-Host ""
Write-Host "[Step 7] Configuring connection string..." -ForegroundColor Yellow

$appsettingsPath = Join-Path $PhysicalPath "appsettings.json"
if (Test-Path $appsettingsPath) {
	$appsettings = Get-Content $appsettingsPath -Raw | ConvertFrom-Json

	# Update connection string
	$connectionString = "Host=$DatabaseServer;Database=$DatabaseName;Username=$DatabaseUser;Password=$DatabasePassword"
	$appsettings.ConnectionStrings.DefaultConnection = $connectionString

	# Save updated settings
	$appsettings | ConvertTo-Json -Depth 10 | Set-Content $appsettingsPath -Encoding UTF8
	Write-Host "  ✓ Connection string updated" -ForegroundColor Green
} else {
	Write-Warning "  appsettings.json not found at $appsettingsPath"
}

# Step 8: Set folder permissions
Write-Host ""
Write-Host "[Step 8] Setting folder permissions..." -ForegroundColor Yellow

$acl = Get-Acl $PhysicalPath
$accessRule = New-Object System.Security.AccessControl.FileSystemAccessRule(
	"IIS_IUSRS", "Read, ReadAndExecute, ListDirectory", 
	"ContainerInherit, ObjectInherit", "None", "Allow"
)
$acl.SetAccessRule($accessRule)

$accessRule2 = New-Object System.Security.AccessControl.FileSystemAccessRule(
	"IUSR", "Read, ReadAndExecute, ListDirectory", 
	"ContainerInherit, ObjectInherit", "None", "Allow"
)
$acl.SetAccessRule($accessRule2)

Set-Acl $PhysicalPath $acl
Write-Host "  ✓ Folder permissions set" -ForegroundColor Green

# Step 9: Create or update IIS Website
Write-Host ""
Write-Host "[Step 9] Configuring IIS Website..." -ForegroundColor Yellow

if (Get-Website -Name $SiteName -ErrorAction SilentlyContinue) {
	Write-Host "  Website '$SiteName' already exists, removing..." -ForegroundColor Gray
	Remove-Website -Name $SiteName -ErrorAction SilentlyContinue
	Start-Sleep -Seconds 2
}

# Create binding
$binding = if ($HostName) {
	"*:${Port}:$HostName"
} else {
	"*:${Port}:"
}

New-Website -Name $SiteName `
	-PhysicalPath $PhysicalPath `
	-ApplicationPool $AppPoolName `
	-BindingInformation $binding `
	-Force | Out-Null

Write-Host "  ✓ Website '$SiteName' created" -ForegroundColor Green
Write-Host "  ✓ Binding: http://*:$Port/" -ForegroundColor Green

# Step 10: Configure firewall
Write-Host ""
Write-Host "[Step 10] Configuring firewall..." -ForegroundColor Yellow

$firewallRuleName = "WordManipulation-Port-$Port"
$existingRule = Get-NetFirewallRule -DisplayName $firewallRuleName -ErrorAction SilentlyContinue

if ($existingRule) {
	Write-Host "  Firewall rule already exists" -ForegroundColor Gray
} else {
	New-NetFirewallRule -DisplayName $firewallRuleName `
		-Direction Inbound `
		-Protocol TCP `
		-LocalPort $Port `
		-Action Allow `
		-Profile Any `
		-ErrorAction SilentlyContinue | Out-Null
	Write-Host "  ✓ Firewall rule created for port $Port" -ForegroundColor Green
}

# Step 11: Start the website
Write-Host ""
Write-Host "[Step 11] Starting website..." -ForegroundColor Yellow

Start-Website -Name $SiteName
Start-Sleep -Seconds 2

$siteState = (Get-Website -Name $SiteName).State
if ($siteState -eq "Started") {
	Write-Host "  ✓ Website started successfully" -ForegroundColor Green
} else {
	Write-Warning "  Website state: $siteState"
}

# Step 12: Test the deployment
Write-Host ""
Write-Host "[Step 12] Testing deployment..." -ForegroundColor Yellow

$localUrl = "http://localhost:$Port"
try {
	$response = Invoke-WebRequest -Uri $localUrl -TimeoutSec 10 -UseBasicParsing -ErrorAction Stop
	if ($response.StatusCode -eq 200) {
		Write-Host "  ✓ Website is responding" -ForegroundColor Green
	}
} catch {
	Write-Warning "  Could not verify website response. Please check manually."
	Write-Warning "  Error: $($_.Exception.Message)"
}

# Summary
Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Deployment Complete!" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""
Write-Host "Site Details:" -ForegroundColor White
Write-Host "  Name:              $SiteName" -ForegroundColor Gray
Write-Host "  Application Pool:  $AppPoolName" -ForegroundColor Gray
Write-Host "  Physical Path:     $PhysicalPath" -ForegroundColor Gray
Write-Host "  Local URL:         http://localhost:$Port" -ForegroundColor Gray

# Get local IP addresses
$ipAddresses = Get-NetIPAddress -AddressFamily IPv4 | Where-Object { $_.InterfaceAlias -notlike "*Loopback*" } | Select-Object -ExpandProperty IPAddress

Write-Host ""
Write-Host "Network URLs (accessible from other machines):" -ForegroundColor White
foreach ($ip in $ipAddresses) {
	Write-Host "  http://${ip}:$Port" -ForegroundColor Cyan
}

Write-Host ""
Write-Host "Database Connection:" -ForegroundColor White
Write-Host "  Server:   $DatabaseServer" -ForegroundColor Gray
Write-Host "  Database: $DatabaseName" -ForegroundColor Gray
Write-Host "  User:     $DatabaseUser" -ForegroundColor Gray

Write-Host ""
Write-Host "Next Steps for Network Deployment:" -ForegroundColor Yellow
Write-Host "  1. Ensure PostgreSQL accepts network connections" -ForegroundColor Gray
Write-Host "  2. Update pg_hba.conf to allow connections from other IPs" -ForegroundColor Gray
Write-Host "  3. Share the network URL with users on the network" -ForegroundColor Gray
Write-Host "  4. For multiple servers, run this script on each machine" -ForegroundColor Gray
Write-Host "     with -DatabaseServer pointing to your central PostgreSQL server" -ForegroundColor Gray
Write-Host ""
Write-Host "To redeploy, run this script again with the same parameters." -ForegroundColor Gray
Write-Host ""
