# =====================================================
# Configure PostgreSQL for Network Access
# =====================================================
# This script helps configure PostgreSQL to accept connections from network machines
# Run this on the PostgreSQL server machine

param(
	[Parameter(Mandatory=$false)]
	[string]$PostgresDataPath = "C:\Program Files\PostgreSQL\15\data",

	[Parameter(Mandatory=$false)]
	[string]$AllowedNetworkCIDR = "192.168.1.0/24"
)

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "PostgreSQL Network Configuration" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Check if running as Administrator
$currentPrincipal = New-Object Security.Principal.WindowsPrincipal([Security.Principal.WindowsIdentity]::GetCurrent())
$isAdmin = $currentPrincipal.IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)

if (-not $isAdmin) {
	Write-Warning "This script should be run as Administrator for best results."
}

# Find PostgreSQL data directory
if (-not (Test-Path $PostgresDataPath)) {
	Write-Host "PostgreSQL data directory not found at: $PostgresDataPath" -ForegroundColor Yellow
	Write-Host "Common locations:" -ForegroundColor Gray
	Write-Host "  C:\Program Files\PostgreSQL\15\data" -ForegroundColor Gray
	Write-Host "  C:\Program Files\PostgreSQL\14\data" -ForegroundColor Gray
	Write-Host "  C:\Program Files\PostgreSQL\13\data" -ForegroundColor Gray
	Write-Host ""
	$customPath = Read-Host "Enter the correct path to PostgreSQL data directory"
	if ($customPath) {
		$PostgresDataPath = $customPath
	} else {
		Write-Error "PostgreSQL data directory is required"
		exit 1
	}
}

Write-Host "Using PostgreSQL data directory: $PostgresDataPath" -ForegroundColor Green
Write-Host ""

# Backup configuration files
Write-Host "[Step 1] Backing up configuration files..." -ForegroundColor Yellow
$timestamp = Get-Date -Format "yyyyMMdd_HHmmss"
$backupPath = Join-Path $PostgresDataPath "backup_$timestamp"

if (-not (Test-Path $backupPath)) {
	New-Item -Path $backupPath -ItemType Directory | Out-Null
}

$pgHbaPath = Join-Path $PostgresDataPath "pg_hba.conf"
$postgresqlConfPath = Join-Path $PostgresDataPath "postgresql.conf"

if (Test-Path $pgHbaPath) {
	Copy-Item $pgHbaPath -Destination (Join-Path $backupPath "pg_hba.conf.backup")
	Write-Host "  ✓ Backed up pg_hba.conf" -ForegroundColor Green
}

if (Test-Path $postgresqlConfPath) {
	Copy-Item $postgresqlConfPath -Destination (Join-Path $backupPath "postgresql.conf.backup")
	Write-Host "  ✓ Backed up postgresql.conf" -ForegroundColor Green
}

# Update postgresql.conf
Write-Host ""
Write-Host "[Step 2] Configuring PostgreSQL to listen on all interfaces..." -ForegroundColor Yellow

$postgresqlConf = Get-Content $postgresqlConfPath
$listenAddressUpdated = $false

$updatedConf = $postgresqlConf | ForEach-Object {
	if ($_ -match "^\s*#?\s*listen_addresses\s*=") {
		$listenAddressUpdated = $true
		"listen_addresses = '*'		# Listen on all network interfaces"
	} else {
		$_
	}
}

if (-not $listenAddressUpdated) {
	$updatedConf += "`nlisten_addresses = '*'		# Listen on all network interfaces"
}

$updatedConf | Set-Content $postgresqlConfPath -Encoding UTF8
Write-Host "  ✓ Updated postgresql.conf" -ForegroundColor Green

# Update pg_hba.conf
Write-Host ""
Write-Host "[Step 3] Configuring client authentication..." -ForegroundColor Yellow

$pgHbaConf = Get-Content $pgHbaPath

# Check if network rule already exists
$networkRuleExists = $pgHbaConf | Where-Object { $_ -match "host\s+all\s+all\s+$($AllowedNetworkCIDR.Replace('.', '\.'))" }

if (-not $networkRuleExists) {
	$newRule = @"

# Allow connections from network machines (added by deployment script)
# IPv4 network connections
host    all             all             $AllowedNetworkCIDR       scram-sha-256

"@
	Add-Content -Path $pgHbaPath -Value $newRule -Encoding UTF8
	Write-Host "  ✓ Added network access rule for $AllowedNetworkCIDR" -ForegroundColor Green
} else {
	Write-Host "  Network access rule already exists" -ForegroundColor Gray
}

# Configure Windows Firewall
Write-Host ""
Write-Host "[Step 4] Configuring Windows Firewall..." -ForegroundColor Yellow

$firewallRuleName = "PostgreSQL-Port-5432"
$existingRule = Get-NetFirewallRule -DisplayName $firewallRuleName -ErrorAction SilentlyContinue

if ($existingRule) {
	Write-Host "  Firewall rule already exists" -ForegroundColor Gray
} else {
	New-NetFirewallRule -DisplayName $firewallRuleName `
		-Direction Inbound `
		-Protocol TCP `
		-LocalPort 5432 `
		-Action Allow `
		-Profile Any `
		-ErrorAction Stop | Out-Null
	Write-Host "  ✓ Firewall rule created for port 5432" -ForegroundColor Green
}

# Restart PostgreSQL service
Write-Host ""
Write-Host "[Step 5] Restarting PostgreSQL service..." -ForegroundColor Yellow

$postgresService = Get-Service -Name "postgresql*" -ErrorAction SilentlyContinue | Select-Object -First 1

if ($postgresService) {
	Write-Host "  Found service: $($postgresService.Name)" -ForegroundColor Gray
	Restart-Service -Name $postgresService.Name -Force -ErrorAction Stop
	Start-Sleep -Seconds 3

	$serviceStatus = (Get-Service -Name $postgresService.Name).Status
	if ($serviceStatus -eq "Running") {
		Write-Host "  ✓ PostgreSQL service restarted successfully" -ForegroundColor Green
	} else {
		Write-Warning "  PostgreSQL service status: $serviceStatus"
	}
} else {
	Write-Warning "  PostgreSQL service not found. Please restart manually."
}

# Get server IP address
$ipAddresses = Get-NetIPAddress -AddressFamily IPv4 | Where-Object { $_.InterfaceAlias -notlike "*Loopback*" } | Select-Object -ExpandProperty IPAddress

Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Configuration Complete!" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""
Write-Host "PostgreSQL Server Details:" -ForegroundColor White
Write-Host "  Data Directory:  $PostgresDataPath" -ForegroundColor Gray
Write-Host "  Backup Location: $backupPath" -ForegroundColor Gray
Write-Host ""
Write-Host "Server IP Addresses:" -ForegroundColor White
foreach ($ip in $ipAddresses) {
	Write-Host "  $ip" -ForegroundColor Cyan
}
Write-Host ""
Write-Host "Connection String for Remote Machines:" -ForegroundColor White
$firstIp = $ipAddresses | Select-Object -First 1
Write-Host "  Host=$firstIp;Database=WordManipulationDb;Username=postgres;Password=your_password" -ForegroundColor Gray
Write-Host ""
Write-Host "Next Steps:" -ForegroundColor Yellow
Write-Host "  1. Test connection from another machine using:" -ForegroundColor Gray
Write-Host "     psql -h $firstIp -U postgres -d WordManipulationDb" -ForegroundColor Gray
Write-Host ""
Write-Host "  2. When deploying to other machines, use:" -ForegroundColor Gray
Write-Host "     .\Deploy-ToIIS.ps1 -DatabaseServer $firstIp" -ForegroundColor Gray
Write-Host ""
Write-Host "Configuration files backed up to: $backupPath" -ForegroundColor Gray
Write-Host ""
