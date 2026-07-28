# =====================================================
# Manage Word Manipulation IIS Deployment
# =====================================================
# This script provides common management tasks for the deployed application

param(
	[Parameter(Mandatory=$true)]
	[ValidateSet("Start", "Stop", "Restart", "Status", "Logs", "Uninstall", "Backup")]
	[string]$Action,

	[Parameter(Mandatory=$false)]
	[string]$SiteName = "WordManipulation",

	[Parameter(Mandatory=$false)]
	[string]$AppPoolName = "WordManipulationAppPool",

	[Parameter(Mandatory=$false)]
	[int]$LogLines = 50
)

# Check if running as Administrator
$currentPrincipal = New-Object Security.Principal.WindowsPrincipal([Security.Principal.WindowsIdentity]::GetCurrent())
$isAdmin = $currentPrincipal.IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)

if (-not $isAdmin -and $Action -ne "Status" -and $Action -ne "Logs") {
	Write-Error "This action requires Administrator privileges!"
	exit 1
}

# Import IIS module
Import-Module WebAdministration -ErrorAction SilentlyContinue

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Word Manipulation - Management" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

switch ($Action) {
	"Start" {
		Write-Host "Starting application..." -ForegroundColor Yellow

		# Start Application Pool
		$appPoolState = Get-WebAppPoolState -Name $AppPoolName -ErrorAction SilentlyContinue
		if ($appPoolState) {
			if ($appPoolState.Value -ne "Started") {
				Start-WebAppPool -Name $AppPoolName
				Write-Host "  ✓ Application pool started" -ForegroundColor Green
			} else {
				Write-Host "  ✓ Application pool already running" -ForegroundColor Green
			}
		} else {
			Write-Error "  Application pool '$AppPoolName' not found"
		}

		# Start Website
		$website = Get-Website -Name $SiteName -ErrorAction SilentlyContinue
		if ($website) {
			if ($website.State -ne "Started") {
				Start-Website -Name $SiteName
				Write-Host "  ✓ Website started" -ForegroundColor Green
			} else {
				Write-Host "  ✓ Website already running" -ForegroundColor Green
			}
		} else {
			Write-Error "  Website '$SiteName' not found"
		}

		Write-Host ""
		Write-Host "Application is now running" -ForegroundColor Green
	}

	"Stop" {
		Write-Host "Stopping application..." -ForegroundColor Yellow

		# Stop Website
		$website = Get-Website -Name $SiteName -ErrorAction SilentlyContinue
		if ($website -and $website.State -eq "Started") {
			Stop-Website -Name $SiteName
			Write-Host "  ✓ Website stopped" -ForegroundColor Green
		} else {
			Write-Host "  Website already stopped" -ForegroundColor Gray
		}

		# Stop Application Pool
		$appPoolState = Get-WebAppPoolState -Name $AppPoolName -ErrorAction SilentlyContinue
		if ($appPoolState -and $appPoolState.Value -eq "Started") {
			Stop-WebAppPool -Name $AppPoolName
			Write-Host "  ✓ Application pool stopped" -ForegroundColor Green
		} else {
			Write-Host "  Application pool already stopped" -ForegroundColor Gray
		}

		Write-Host ""
		Write-Host "Application stopped" -ForegroundColor Green
	}

	"Restart" {
		Write-Host "Restarting application..." -ForegroundColor Yellow

		# Restart Application Pool
		Restart-WebAppPool -Name $AppPoolName -ErrorAction SilentlyContinue
		Write-Host "  ✓ Application pool restarted" -ForegroundColor Green

		Start-Sleep -Seconds 2

		# Restart Website
		Stop-Website -Name $SiteName -ErrorAction SilentlyContinue
		Start-Sleep -Seconds 1
		Start-Website -Name $SiteName -ErrorAction SilentlyContinue
		Write-Host "  ✓ Website restarted" -ForegroundColor Green

		Write-Host ""
		Write-Host "Application restarted successfully" -ForegroundColor Green
	}

	"Status" {
		Write-Host "Checking application status..." -ForegroundColor Yellow
		Write-Host ""

		# Website Status
		$website = Get-Website -Name $SiteName -ErrorAction SilentlyContinue
		if ($website) {
			Write-Host "Website: $SiteName" -ForegroundColor White
			Write-Host "  State:         $($website.State)" -ForegroundColor $(if($website.State -eq "Started"){"Green"}else{"Red"})
			Write-Host "  Physical Path: $($website.PhysicalPath)" -ForegroundColor Gray
			Write-Host "  Bindings:" -ForegroundColor Gray
			foreach ($binding in $website.Bindings.Collection) {
				Write-Host "    - $($binding.protocol)://$($binding.bindingInformation)" -ForegroundColor Gray
			}
		} else {
			Write-Host "Website: NOT FOUND" -ForegroundColor Red
		}

		Write-Host ""

		# Application Pool Status
		$appPool = Get-Item "IIS:\AppPools\$AppPoolName" -ErrorAction SilentlyContinue
		if ($appPool) {
			$appPoolState = Get-WebAppPoolState -Name $AppPoolName
			Write-Host "Application Pool: $AppPoolName" -ForegroundColor White
			Write-Host "  State:                 $($appPoolState.Value)" -ForegroundColor $(if($appPoolState.Value -eq "Started"){"Green"}else{"Red"})
			Write-Host "  .NET CLR Version:      $($appPool.managedRuntimeVersion)" -ForegroundColor Gray
			Write-Host "  Pipeline Mode:         $($appPool.managedPipelineMode)" -ForegroundColor Gray
			Write-Host "  Start Mode:            $($appPool.startMode)" -ForegroundColor Gray
			Write-Host "  Identity:              $($appPool.processModel.identityType)" -ForegroundColor Gray
		} else {
			Write-Host "Application Pool: NOT FOUND" -ForegroundColor Red
		}

		Write-Host ""

		# Network Information
		$ipAddresses = Get-NetIPAddress -AddressFamily IPv4 | Where-Object { $_.InterfaceAlias -notlike "*Loopback*" }
		if ($ipAddresses -and $website) {
			Write-Host "Access URLs:" -ForegroundColor White
			$port = ($website.Bindings.Collection[0].bindingInformation -split ':')[1]
			Write-Host "  Local:   http://localhost:$port" -ForegroundColor Cyan
			foreach ($ip in $ipAddresses) {
				Write-Host "  Network: http://$($ip.IPAddress):$port" -ForegroundColor Cyan
			}
		}

		Write-Host ""

		# Process Information
		$w3wpProcesses = Get-Process -Name "w3wp" -ErrorAction SilentlyContinue | Where-Object {
			$_.Modules.ModuleName -contains "aspnetcorev2.dll" -or 
			$_.Modules.ModuleName -contains "aspnetcore.dll"
		}

		if ($w3wpProcesses) {
			Write-Host "Running Processes:" -ForegroundColor White
			foreach ($proc in $w3wpProcesses) {
				$memory = [math]::Round($proc.WorkingSet64 / 1MB, 2)
				Write-Host "  PID: $($proc.Id)" -ForegroundColor Gray
				Write-Host "    Memory: ${memory}MB" -ForegroundColor Gray
				Write-Host "    Started: $($proc.StartTime)" -ForegroundColor Gray
			}
		} else {
			Write-Host "No application processes running" -ForegroundColor Yellow
		}
	}

	"Logs" {
		Write-Host "Retrieving logs..." -ForegroundColor Yellow
		Write-Host ""

		# IIS Logs
		$logPath = "C:\inetpub\logs\LogFiles"
		if (Test-Path $logPath) {
			$latestLog = Get-ChildItem -Path $logPath -Recurse -Filter "*.log" | 
						 Sort-Object LastWriteTime -Descending | 
						 Select-Object -First 1

			if ($latestLog) {
				Write-Host "Latest IIS Log: $($latestLog.FullName)" -ForegroundColor White
				Write-Host "Last Modified: $($latestLog.LastWriteTime)" -ForegroundColor Gray
				Write-Host ""
				Write-Host "Last $LogLines lines:" -ForegroundColor White
				Write-Host "----------------------------------------" -ForegroundColor Gray
				Get-Content $latestLog.FullName -Tail $LogLines
				Write-Host "----------------------------------------" -ForegroundColor Gray
			} else {
				Write-Host "No log files found" -ForegroundColor Yellow
			}
		} else {
			Write-Host "Log directory not found: $logPath" -ForegroundColor Yellow
		}

		Write-Host ""

		# Application Event Log
		Write-Host "Recent Application Errors:" -ForegroundColor White
		Write-Host "----------------------------------------" -ForegroundColor Gray
		$appErrors = Get-EventLog -LogName Application -EntryType Error -Newest $LogLines -ErrorAction SilentlyContinue |
					 Where-Object { $_.Source -like "*IIS*" -or $_.Source -like "*.NET*" -or $_.Source -like "*ASP.NET*" } |
					 Select-Object -First 10

		if ($appErrors) {
			foreach ($error in $appErrors) {
				Write-Host "[$($error.TimeGenerated)] $($error.Source)" -ForegroundColor Red
				Write-Host "  $($error.Message.Split("`n")[0])" -ForegroundColor Gray
				Write-Host ""
			}
		} else {
			Write-Host "No recent errors found" -ForegroundColor Green
		}
	}

	"Backup" {
		Write-Host "Creating backup..." -ForegroundColor Yellow

		$website = Get-Website -Name $SiteName -ErrorAction SilentlyContinue
		if (-not $website) {
			Write-Error "Website '$SiteName' not found"
			exit 1
		}

		$physicalPath = $website.PhysicalPath
		$timestamp = Get-Date -Format "yyyyMMdd_HHmmss"
		$backupPath = Join-Path $env:TEMP "WordManipulation_Backup_$timestamp"

		# Create backup directory
		New-Item -Path $backupPath -ItemType Directory -Force | Out-Null

		# Copy files
		Write-Host "  Backing up application files..." -ForegroundColor Gray
		Copy-Item -Path $physicalPath -Destination (Join-Path $backupPath "app") -Recurse -Force

		# Export IIS configuration
		Write-Host "  Exporting IIS configuration..." -ForegroundColor Gray
		$configBackup = @{
			Website = Get-Website -Name $SiteName | Select-Object *
			AppPool = Get-Item "IIS:\AppPools\$AppPoolName" | Select-Object *
			Bindings = $website.Bindings.Collection | ForEach-Object { $_.bindingInformation }
		}
		$configBackup | ConvertTo-Json -Depth 10 | Out-File (Join-Path $backupPath "iis_config.json") -Encoding UTF8

		# Compress backup
		$zipPath = "$backupPath.zip"
		Write-Host "  Compressing backup..." -ForegroundColor Gray
		Compress-Archive -Path $backupPath -DestinationPath $zipPath -Force

		# Clean up temp folder
		Remove-Item -Path $backupPath -Recurse -Force

		Write-Host ""
		Write-Host "  ✓ Backup created: $zipPath" -ForegroundColor Green
		Write-Host ""
		Write-Host "Backup size: $([math]::Round((Get-Item $zipPath).Length / 1MB, 2))MB" -ForegroundColor Gray
	}

	"Uninstall" {
		Write-Host "Uninstalling application..." -ForegroundColor Yellow
		Write-Host ""

		$confirm = Read-Host "Are you sure you want to uninstall? This will remove the website and application pool. (Y/N)"
		if ($confirm -ne "Y" -and $confirm -ne "y") {
			Write-Host "Uninstall cancelled" -ForegroundColor Gray
			exit 0
		}

		# Stop and remove website
		$website = Get-Website -Name $SiteName -ErrorAction SilentlyContinue
		if ($website) {
			Write-Host "  Removing website..." -ForegroundColor Gray
			Stop-Website -Name $SiteName -ErrorAction SilentlyContinue
			Remove-Website -Name $SiteName -ErrorAction SilentlyContinue
			Write-Host "  ✓ Website removed" -ForegroundColor Green
		}

		# Stop and remove application pool
		$appPool = Get-Item "IIS:\AppPools\$AppPoolName" -ErrorAction SilentlyContinue
		if ($appPool) {
			Write-Host "  Removing application pool..." -ForegroundColor Gray
			Stop-WebAppPool -Name $AppPoolName -ErrorAction SilentlyContinue
			Remove-WebAppPool -Name $AppPoolName -ErrorAction SilentlyContinue
			Write-Host "  ✓ Application pool removed" -ForegroundColor Green
		}

		# Ask about files
		if ($website) {
			$physicalPath = $website.PhysicalPath
			Write-Host ""
			$deleteFiles = Read-Host "Delete application files at $physicalPath? (Y/N)"
			if ($deleteFiles -eq "Y" -or $deleteFiles -eq "y") {
				if (Test-Path $physicalPath) {
					Remove-Item -Path $physicalPath -Recurse -Force
					Write-Host "  ✓ Application files deleted" -ForegroundColor Green
				}
			}
		}

		# Remove firewall rules
		Write-Host ""
		Write-Host "  Removing firewall rules..." -ForegroundColor Gray
		$firewallRules = Get-NetFirewallRule -DisplayName "*WordManipulation*" -ErrorAction SilentlyContinue
		foreach ($rule in $firewallRules) {
			Remove-NetFirewallRule -DisplayName $rule.DisplayName -ErrorAction SilentlyContinue
		}
		Write-Host "  ✓ Firewall rules removed" -ForegroundColor Green

		Write-Host ""
		Write-Host "Uninstallation complete" -ForegroundColor Green
		Write-Host ""
		Write-Host "Note: PostgreSQL database was not removed." -ForegroundColor Yellow
		Write-Host "To remove database data, use PostgreSQL tools." -ForegroundColor Gray
	}
}

Write-Host ""
