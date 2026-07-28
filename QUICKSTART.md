# Quick Start Guide - Word Manipulation IIS Deployment

## 🚀 Quick Start (Single Machine)

For a simple deployment on one machine (both web and database):

```powershell
# 1. Open PowerShell as Administrator

# 2. Navigate to the project directory
cd "C:\Users\bmich\source\repos\KostasMihawk\WordManipulationDotNet7"

# 3. Check if your system is ready
.\Check-Prerequisites.ps1

# 4. Deploy the application
.\Deploy-ToIIS.ps1
```

That's it! Open your browser to: `http://localhost:8080`

---

## 🌐 Network Deployment (Multiple Machines)

### Setup 1: Configure Database Server

On the machine that will host PostgreSQL:

```powershell
# 1. Install PostgreSQL if not already installed
# Download from: https://www.postgresql.org/download/windows/

# 2. Open PowerShell as Administrator and navigate to project directory

# 3. Configure PostgreSQL for network access
.\Configure-PostgreSQLNetwork.ps1

# 4. Note the server IP address shown in the output (e.g., 192.168.1.100)
```

### Setup 2: Deploy Web Application

On each machine that will host the web application:

```powershell
# 1. Copy the project folder to the machine

# 2. Open PowerShell as Administrator and navigate to project directory

# 3. Check prerequisites
.\Check-Prerequisites.ps1

# 4. Deploy with database server IP
.\Deploy-ToIIS.ps1 -DatabaseServer "192.168.1.100" -DatabasePassword "your_password"
```

Access the application: `http://<web-server-ip>:8080`

---

## 📋 What Each Script Does

### Check-Prerequisites.ps1
- ✅ Verifies system is ready for deployment
- ✅ Checks for required software
- ✅ Reports any issues
- **Run this first!**

### Deploy-ToIIS.ps1
- 🔧 Installs IIS (if needed)
- 📦 Publishes the application
- ⚙️ Configures IIS website and app pool
- 🔒 Sets up firewall rules
- 🎯 Deploys and starts the application

### Configure-PostgreSQLNetwork.ps1
- 🌐 Configures PostgreSQL for network access
- 🔓 Opens firewall port 5432
- 📝 Updates configuration files
- 🔄 Restarts PostgreSQL service

---

## 🔍 Common Scenarios

### Scenario 1: Development Machine
```powershell
.\Deploy-ToIIS.ps1
```

### Scenario 2: Production Server (Single Machine)
```powershell
.\Deploy-ToIIS.ps1 -Port 80 -DatabasePassword "SecurePassword123"
```

### Scenario 3: Separate Web and Database Servers
**On DB server:**
```powershell
.\Configure-PostgreSQLNetwork.ps1
```

**On web server:**
```powershell
.\Deploy-ToIIS.ps1 -DatabaseServer "192.168.1.100" -DatabasePassword "SecurePassword123"
```

### Scenario 4: Multiple Web Servers + One Database
**On DB server:**
```powershell
.\Configure-PostgreSQLNetwork.ps1 -AllowedNetworkCIDR "192.168.1.0/24"
```

**On each web server:**
```powershell
.\Deploy-ToIIS.ps1 -DatabaseServer "192.168.1.100" -DatabasePassword "SecurePassword123"
```

---

## ⚙️ Script Parameters

### Deploy-ToIIS.ps1 Parameters

```powershell
.\Deploy-ToIIS.ps1 `
	-SiteName "WordManipulation" `          # IIS site name
	-Port 8080 `                            # HTTP port
	-DatabaseServer "localhost" `           # Database server IP or hostname
	-DatabaseName "WordManipulationDb" `    # Database name
	-DatabaseUser "postgres" `              # Database username
	-DatabasePassword "pwd"                 # Database password
```

### Configure-PostgreSQLNetwork.ps1 Parameters

```powershell
.\Configure-PostgreSQLNetwork.ps1 `
	-PostgresDataPath "C:\Program Files\PostgreSQL\15\data" `  # PostgreSQL data directory
	-AllowedNetworkCIDR "192.168.1.0/24"                       # Network CIDR to allow
```

---

## 🆘 Troubleshooting

### "Access Denied" or "Permission Error"
**Solution:** Run PowerShell as Administrator

### "Project file not found"
**Solution:** Make sure you're in the correct directory (solution root)

### "Cannot connect to database"
**Solution:** 
1. Check if PostgreSQL is running
2. Verify firewall allows port 5432
3. Test connection: `Test-NetConnection -ComputerName <DB_IP> -Port 5432`

### "Website shows 503 error"
**Solution:**
1. Install ASP.NET Core Hosting Bundle
2. Download from: https://dotnet.microsoft.com/download/dotnet/8.0
3. Re-run deployment script

### "Can't access from other machines"
**Solution:**
1. Check Windows Firewall allows port 8080
2. Verify corporate firewall settings
3. Test: `Test-NetConnection -ComputerName <WEB_SERVER_IP> -Port 8080`

---

## 🔄 Updating the Application

To update an existing deployment:

```powershell
# Just re-run the deployment script with the same parameters
.\Deploy-ToIIS.ps1 -DatabaseServer "192.168.1.100"
```

The script will:
- Stop the website
- Publish latest code
- Replace files
- Restart the website

---

## 📊 Verify Deployment

### Check if website is running:
```powershell
Get-Website -Name "WordManipulation"
```

### Check application pool:
```powershell
Get-WebAppPoolState -Name "WordManipulationAppPool"
```

### Test from browser:
- Local: `http://localhost:8080`
- Network: `http://<server-ip>:8080`
- Admin: `http://<server-ip>:8080/Admin`

---

## 📞 Getting Help

1. **Check script output** - Scripts provide detailed messages
2. **Run Check-Prerequisites.ps1** - Identifies missing components
3. **Review DEPLOYMENT.md** - Comprehensive deployment guide
4. **Check Windows Event Viewer** - Application and System logs
5. **Check IIS logs** - Located in `C:\inetpub\logs\LogFiles\`

---

## 🔐 Security Tips

1. **Change default password**: Don't use "pwd" in production
2. **Use HTTPS**: Configure SSL certificates for production
3. **Restrict firewall**: Allow only necessary IP addresses
4. **Update regularly**: Keep Windows, IIS, and PostgreSQL updated
5. **Backup database**: Schedule regular PostgreSQL backups

---

## 📚 Next Steps

After successful deployment:

1. ✅ Access the admin panel: `http://<server-ip>:8080/Admin`
2. ✅ Verify all seeded data is present
3. ✅ Test document generation features
4. ✅ Add additional users/data as needed
5. ✅ Configure backups
6. ✅ Set up monitoring

---

## Network Access Summary

| From | To | Port | Purpose |
|------|-----|------|---------|
| Browser | Web Server | 8080 | Access application |
| Web Server | DB Server | 5432 | Database queries |
| Browser | DB Server | - | No direct access needed |

---

## Port Reference

- **5432**: PostgreSQL database
- **8080**: Web application (default, can be changed)
- **80**: Standard HTTP (use `-Port 80` for production)
- **443**: HTTPS (requires SSL certificate configuration)

---

## Useful Commands

```powershell
# Check deployment status
Get-Website -Name "WordManipulation"
Get-WebAppPoolState -Name "WordManipulationAppPool"

# Restart application
Restart-WebAppPool -Name "WordManipulationAppPool"

# View recent logs
Get-Content "C:\inetpub\logs\LogFiles\W3SVC*\*.log" -Tail 50

# Test database connection
Test-NetConnection -ComputerName <DB_SERVER> -Port 5432

# Check if port is listening
Get-NetTCPConnection -LocalPort 8080

# Check firewall rules
Get-NetFirewallRule -DisplayName "*WordManipulation*"
```

---

## System Requirements

### Minimum:
- Windows 10/Server 2016 or later
- 2 GB RAM
- 10 GB disk space
- .NET 8 Runtime

### Recommended:
- Windows 11/Server 2022
- 4 GB RAM
- 20 GB disk space
- .NET 8 SDK
- Dedicated network interface

---

**Ready to deploy?** Run `.\Check-Prerequisites.ps1` to get started! 🚀
