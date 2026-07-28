# Word Manipulation Application - Deployment Scripts

## 📦 Complete IIS Deployment Solution

This folder contains everything you need to deploy the Word Manipulation application to IIS on single or multiple machines in your network.

---

## 📂 Files Overview

| File | Purpose |
|------|---------|
| **Check-Prerequisites.ps1** | Validates your system is ready for deployment |
| **Deploy-ToIIS.ps1** | Main deployment script - installs and configures everything |
| **Configure-PostgreSQLNetwork.ps1** | Configures PostgreSQL to accept network connections |
| **Manage-Deployment.ps1** | Management script for start/stop/restart/logs/backup |
| **QUICKSTART.md** | Quick start guide - read this first! |
| **DEPLOYMENT.md** | Comprehensive deployment documentation |

---

## 🚀 Getting Started

### For Beginners - Single Machine Setup

1. **Open PowerShell as Administrator**

2. **Check if system is ready:**
   ```powershell
   .\Check-Prerequisites.ps1
   ```

3. **Deploy the application:**
   ```powershell
   .\Deploy-ToIIS.ps1
   ```

4. **Open browser to:** `http://localhost:8080`

That's it! See **QUICKSTART.md** for more details.

---

## 🌐 For Network Deployment

### Step 1: Setup Database Server
On the machine hosting PostgreSQL:
```powershell
.\Configure-PostgreSQLNetwork.ps1
```

### Step 2: Deploy Web Server(s)
On each web server machine:
```powershell
.\Deploy-ToIIS.ps1 -DatabaseServer "192.168.1.100" -DatabasePassword "your_password"
```

See **DEPLOYMENT.md** for detailed instructions.

---

## 🛠️ Managing Your Deployment

### Common Management Tasks

```powershell
# Check application status
.\Manage-Deployment.ps1 -Action Status

# Start the application
.\Manage-Deployment.ps1 -Action Start

# Stop the application
.\Manage-Deployment.ps1 -Action Stop

# Restart the application
.\Manage-Deployment.ps1 -Action Restart

# View logs
.\Manage-Deployment.ps1 -Action Logs

# Create backup
.\Manage-Deployment.ps1 -Action Backup

# Uninstall
.\Manage-Deployment.ps1 -Action Uninstall
```

---

## 📖 Documentation

- **QUICKSTART.md** - Start here if you're new
- **DEPLOYMENT.md** - Complete deployment guide with all scenarios
- **README.md** - This file

---

## 🔧 Deployment Options

### Deploy-ToIIS.ps1 Parameters

| Parameter | Default | Description |
|-----------|---------|-------------|
| `-SiteName` | WordManipulation | IIS website name |
| `-Port` | 8080 | HTTP port |
| `-DatabaseServer` | localhost | PostgreSQL server address |
| `-DatabaseName` | WordManipulationDb | Database name |
| `-DatabaseUser` | postgres | Database username |
| `-DatabasePassword` | pwd | Database password |

### Examples

**Local deployment:**
```powershell
.\Deploy-ToIIS.ps1
```

**Remote database:**
```powershell
.\Deploy-ToIIS.ps1 -DatabaseServer "192.168.1.100" -DatabasePassword "SecurePass123"
```

**Custom port:**
```powershell
.\Deploy-ToIIS.ps1 -Port 80
```

**Full custom:**
```powershell
.\Deploy-ToIIS.ps1 `
	-SiteName "MyWordApp" `
	-Port 80 `
	-DatabaseServer "db.company.local" `
	-DatabaseName "WordDB" `
	-DatabaseUser "appuser" `
	-DatabasePassword "SecurePassword123"
```

---

## ✅ Prerequisites

Before deployment, ensure you have:

- ✅ Windows 10/11 or Windows Server 2016+
- ✅ Administrator access
- ✅ PowerShell 5.1 or later
- ✅ Internet connection (for downloading components)
- ✅ .NET 8 SDK or Runtime
- ✅ PostgreSQL (local or network accessible)

Run `.\Check-Prerequisites.ps1` to verify all requirements.

---

## 🎯 What Gets Installed

The deployment script will automatically:

1. ✅ Install IIS with required features
2. ✅ Install ASP.NET Core Hosting Bundle (if needed)
3. ✅ Create IIS application pool
4. ✅ Publish the application
5. ✅ Configure database connection
6. ✅ Set up firewall rules
7. ✅ Deploy and start the website

---

## 🌐 Network Architecture

### Single Machine (Development)
```
┌──────────────────────┐
│   Your Computer      │
│                      │
│  ┌──────────────┐   │
│  │ IIS + App    │   │
│  └──────┬───────┘   │
│         │           │
│  ┌──────▼───────┐   │
│  │  PostgreSQL  │   │
│  └──────────────┘   │
└──────────────────────┘
```

### Separate Servers (Production)
```
┌──────────────┐         ┌──────────────┐
│ Web Server   │         │  DB Server   │
│              │         │              │
│ ┌──────────┐│  Port   │┌────────────┐│
│ │   IIS    ││  5432   ││ PostgreSQL ││
│ │   App    ││────────>││            ││
│ └──────────┘│         │└────────────┘│
└──────────────┘         └──────────────┘
	   ▲
	   │ Port 8080
	   │
┌──────┴───────┐
│   Users      │
│  (Browsers)  │
└──────────────┘
```

### Multiple Web Servers (High Availability)
```
┌──────────────┐
│ Web Server 1 │──┐
└──────────────┘  │
				  │     ┌──────────────┐
┌──────────────┐  │     │  DB Server   │
│ Web Server 2 │──┼────>│              │
└──────────────┘  │     │┌────────────┐│
				  │     ││ PostgreSQL ││
┌──────────────┐  │     │└────────────┘│
│ Web Server 3 │──┘     └──────────────┘
└──────────────┘
	   ▲
	   │
┌──────┴───────┐
│Load Balancer │
│   (Optional) │
└──────────────┘
```

---

## 🔒 Security Considerations

1. **Change default passwords** - Never use "pwd" in production
2. **Configure HTTPS** - Set up SSL certificates
3. **Firewall rules** - Restrict access to known IPs
4. **Regular updates** - Keep Windows, IIS, and PostgreSQL updated
5. **Database backups** - Schedule regular PostgreSQL backups
6. **Monitor logs** - Check IIS and application logs regularly

---

## 📊 After Deployment

Your application will be accessible at:

- **Local machine:** `http://localhost:8080`
- **Network:** `http://<server-ip>:8080`
- **Admin panel:** `http://<server-ip>:8080/Admin`

Default data will be seeded including:
- 27 Funds
- 70+ Document Templates  
- Attorneys/Notaries
- Bailiffs
- Zones
- Banks
- Debtors

---

## 🆘 Troubleshooting

### Common Issues and Solutions

**"Access Denied"**
- Run PowerShell as Administrator

**"Cannot connect to database"**
- Check PostgreSQL is running
- Verify firewall allows port 5432
- Test: `Test-NetConnection -ComputerName <DB_IP> -Port 5432`

**"Website shows 503"**
- Install ASP.NET Core Hosting Bundle
- Download: https://dotnet.microsoft.com/download/dotnet/8.0

**"Can't access from other machines"**
- Check Windows Firewall allows port 8080
- Test: `Test-NetConnection -ComputerName <WEB_IP> -Port 8080`

**Need more help?**
- Check `.\Manage-Deployment.ps1 -Action Logs`
- Review Windows Event Viewer
- See DEPLOYMENT.md for detailed troubleshooting

---

## 🔄 Updating

To update an existing deployment:

```powershell
# Simply re-run the deployment script
.\Deploy-ToIIS.ps1 -DatabaseServer "192.168.1.100"
```

The script automatically:
- Stops the website
- Publishes latest code
- Replaces files
- Restarts the website

---

## 📞 Support & Resources

- **Quick Start:** QUICKSTART.md
- **Full Documentation:** DEPLOYMENT.md
- **IIS Docs:** https://docs.microsoft.com/iis/
- **ASP.NET Core:** https://docs.microsoft.com/aspnet/core/host-and-deploy/iis/
- **PostgreSQL:** https://www.postgresql.org/docs/

---

## 📝 Version History

- **v1.0** - Initial release
  - Full IIS deployment automation
  - Network configuration support
  - Management scripts
  - Comprehensive documentation

---

## ⚙️ Advanced Configuration

### Custom IIS Settings

After deployment, you can customize IIS settings:

```powershell
# Import IIS module
Import-Module WebAdministration

# View site settings
Get-Website -Name "WordManipulation"

# View app pool settings
Get-Item "IIS:\AppPools\WordManipulationAppPool"

# Modify settings
Set-ItemProperty "IIS:\Sites\WordManipulation" -Name "limits.connectionTimeout" -Value "00:05:00"
```

### Load Balancing

For multiple web servers, configure Windows Network Load Balancing:

1. Install NLB feature:
   ```powershell
   Install-WindowsFeature NLB -IncludeManagementTools
   ```

2. Configure NLB cluster
3. Add web servers to cluster
4. Configure virtual IP and port rules

### HTTPS Configuration

To enable HTTPS:

1. Obtain SSL certificate
2. Import certificate to Windows certificate store
3. Add HTTPS binding:
   ```powershell
   New-WebBinding -Name "WordManipulation" `
	   -Protocol "https" `
	   -Port 443 `
	   -HostHeader "yourdomain.com" `
	   -SslFlags 0
   ```

---

## 🎓 Learning Resources

New to IIS deployment? Check these resources:

- [Microsoft IIS Getting Started](https://docs.microsoft.com/iis/get-started/)
- [ASP.NET Core on IIS](https://docs.microsoft.com/aspnet/core/host-and-deploy/iis/)
- [PostgreSQL Administration](https://www.postgresql.org/docs/current/admin.html)

---

## 🤝 Contributing

Found an issue or have a suggestion? Please let us know!

---

## 📄 License

This deployment solution is part of the Word Manipulation Application.

---

**Ready to deploy?** Start with `.\Check-Prerequisites.ps1` and follow the prompts! 🚀

For detailed instructions, see **QUICKSTART.md** or **DEPLOYMENT.md**.
