# =====================================================
# Check Prerequisites for IIS Deployment
# =====================================================
# This script checks if the system is ready for deployment

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Prerequisites Check" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

$allGood = $true

# Check 1: Administrator privileges
Write-Host "[1] Checking Administrator privileges..." -ForegroundColor Yellow
$currentPrincipal = New-Object Security.Principal.WindowsPrincipal([Security.Principal.WindowsIdentity]::GetCurrent())
$isAdmin = $currentPrincipal.IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)

if ($isAdmin) {
	Write-Host "  ✓ Running as Administrator" -ForegroundColor Green
} else {
	Write-Host "  ✗ NOT running as Administrator" -ForegroundColor Red
	Write-Host "    Please run PowerShell as Administrator" -ForegroundColor Yellow
	$allGood = $false
}

# Check 2: PowerShell version
Write-Host ""
Write-Host "[2] Checking PowerShell version..." -ForegroundColor Yellow
$psVersion = $PSVersionTable.PSVersion
if ($psVersion.Major -ge 5) {
	Write-Host "  ✓ PowerShell $($psVersion.Major).$($psVersion.Minor)" -ForegroundColor Green
} else {
	Write-Host "  ✗ PowerShell version too old: $($psVersion.Major).$($psVersion.Minor)" -ForegroundColor Red
	Write-Host "    Please upgrade to PowerShell 5.1 or later" -ForegroundColor Yellow
	$allGood = $false
}

# Check 3: .NET SDK/Runtime
Write-Host ""
Write-Host "[3] Checking .NET installation..." -ForegroundColor Yellow
try {
	$dotnetVersion = dotnet --version 2>$null
	if ($dotnetVersion) {
		Write-Host "  ✓ .NET SDK/Runtime installed: $dotnetVersion" -ForegroundColor Green

		# Check for .NET 8
		$dotnetInfo = dotnet --list-sdks 2>$null
		if ($dotnetInfo -match "8\.0") {
			Write-Host "  ✓ .NET 8 SDK found" -ForegroundColor Green
		} else {
			Write-Host "  ! .NET 8 SDK not found (current: $dotnetVersion)" -ForegroundColor Yellow
			Write-Host "    Download from: https://dotnet.microsoft.com/download/dotnet/8.0" -ForegroundColor Gray
		}
	}
} catch {
	Write-Host "  ✗ .NET not found" -ForegroundColor Red
	Write-Host "    Download from: https://dotnet.microsoft.com/download/dotnet/8.0" -ForegroundColor Yellow
	$allGood = $false
}

# Check 4: IIS
Write-Host ""
Write-Host "[4] Checking IIS..." -ForegroundColor Yellow
$iisFeature = Get-WindowsOptionalFeature -Online -FeatureName IIS-WebServerRole -ErrorAction SilentlyContinue
if ($iisFeature -and $iisFeature.State -eq "Enabled") {
	Write-Host "  ✓ IIS is installed" -ForegroundColor Green
} else {
	Write-Host "  ! IIS not installed (will be installed by deployment script)" -ForegroundColor Yellow
}

# Check 5: ASP.NET Core Hosting Bundle
Write-Host ""
Write-Host "[5] Checking ASP.NET Core Hosting Bundle..." -ForegroundColor Yellow
$hostingBundle = Get-ItemProperty "HKLM:\SOFTWARE\dotnet\Setup\InstalledVersions\x64\sharedhost" -ErrorAction SilentlyContinue
if ($hostingBundle) {
	Write-Host "  ✓ ASP.NET Core Hosting Bundle installed" -ForegroundColor Green
} else {
	Write-Host "  ! ASP.NET Core Hosting Bundle not found" -ForegroundColor Yellow
	Write-Host "    Download from: https://dotnet.microsoft.com/download/dotnet/8.0" -ForegroundColor Gray
	Write-Host "    Look for: ASP.NET Core Runtime 8.0.x Hosting Bundle" -ForegroundColor Gray
}

# Check 6: PostgreSQL
Write-Host ""
Write-Host "[6] Checking PostgreSQL..." -ForegroundColor Yellow
$postgresService = Get-Service -Name "postgresql*" -ErrorAction SilentlyContinue
if ($postgresService) {
	Write-Host "  ✓ PostgreSQL service found: $($postgresService.Name)" -ForegroundColor Green
	if ($postgresService.Status -eq "Running") {
		Write-Host "  ✓ PostgreSQL is running" -ForegroundColor Green
	} else {
		Write-Host "  ! PostgreSQL service is stopped" -ForegroundColor Yellow
		Write-Host "    Start with: Start-Service -Name $($postgresService.Name)" -ForegroundColor Gray
	}
} else {
	Write-Host "  ! PostgreSQL not found" -ForegroundColor Yellow
	Write-Host "    If using a remote database, this is OK" -ForegroundColor Gray
	Write-Host "    Otherwise, install from: https://www.postgresql.org/download/windows/" -ForegroundColor Gray
}

# Check 7: Network connectivity
Write-Host ""
Write-Host "[7] Checking network configuration..." -ForegroundColor Yellow
$ipAddresses = Get-NetIPAddress -AddressFamily IPv4 | Where-Object { $_.InterfaceAlias -notlike "*Loopback*" }
if ($ipAddresses) {
	Write-Host "  ✓ Network interfaces found:" -ForegroundColor Green
	foreach ($ip in $ipAddresses) {
		Write-Host "    - $($ip.IPAddress) ($($ip.InterfaceAlias))" -ForegroundColor Gray
	}
} else {
	Write-Host "  ✗ No network interfaces found" -ForegroundColor Red
	$allGood = $false
}

# Check 8: Firewall status
Write-Host ""
Write-Host "[8] Checking Windows Firewall..." -ForegroundColor Yellow
$firewallProfiles = Get-NetFirewallProfile
$activeProfiles = $firewallProfiles | Where-Object { $_.Enabled -eq $true }
if ($activeProfiles) {
	Write-Host "  ✓ Windows Firewall is active" -ForegroundColor Green
	foreach ($profile in $activeProfiles) {
		Write-Host "    - $($profile.Name) profile: Enabled" -ForegroundColor Gray
	}
} else {
	Write-Host "  ! Windows Firewall is disabled" -ForegroundColor Yellow
}

# Check 9: Disk space
Write-Host ""
Write-Host "[9] Checking disk space..." -ForegroundColor Yellow
$systemDrive = Get-PSDrive -Name C -ErrorAction SilentlyContinue
if ($systemDrive) {
	$freeSpaceGB = [math]::Round($systemDrive.Free / 1GB, 2)
	if ($freeSpaceGB -gt 5) {
		Write-Host "  ✓ Available disk space: ${freeSpaceGB}GB" -ForegroundColor Green
	} else {
		Write-Host "  ! Low disk space: ${freeSpaceGB}GB" -ForegroundColor Yellow
		Write-Host "    Recommended: At least 5GB free" -ForegroundColor Gray
	}
}

# Check 10: Project files
Write-Host ""
Write-Host "[10] Checking project files..." -ForegroundColor Yellow
$projectFile = Join-Path $PSScriptRoot "WordManipulationDotNet7\WordManipulationDotNet7.csproj"
if (Test-Path $projectFile) {
	Write-Host "  ✓ Project file found" -ForegroundColor Green
} else {
	Write-Host "  ✗ Project file not found at: $projectFile" -ForegroundColor Red
	Write-Host "    Make sure deployment scripts are in the solution root" -ForegroundColor Yellow
	$allGood = $false
}

# Summary
Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
if ($allGood) {
	Write-Host "✓ All critical checks passed!" -ForegroundColor Green
	Write-Host "========================================" -ForegroundColor Cyan
	Write-Host ""
	Write-Host "You can proceed with deployment:" -ForegroundColor White
	Write-Host "  .\Deploy-ToIIS.ps1" -ForegroundColor Cyan
} else {
	Write-Host "✗ Some checks failed" -ForegroundColor Red
	Write-Host "========================================" -ForegroundColor Cyan
	Write-Host ""
	Write-Host "Please address the issues marked with ✗ above" -ForegroundColor Yellow
}

Write-Host ""
Write-Host "For detailed deployment instructions, see DEPLOYMENT.md" -ForegroundColor Gray
Write-Host ""
