# Word Manipulation Application - IIS Deployment Guide

## Overview
This guide explains how to deploy the Word Manipulation application to IIS on one or multiple machines in your network.

## Prerequisites

### On Each Web Server Machine:
- Windows Server 2016+ or Windows 10/11
- PowerShell 5.1 or later
- Administrator access
- .NET 8 SDK (for building) or Runtime (for running)
- IIS Web Server

### On the Database Server Machine:
- PostgreSQL 13 or later installed and running
- Network connectivity between web servers and database server

---

## Deployment Scenarios

### Scenario 1: Single Machine Deployment
Everything (web app and database) runs on one machine.

**Steps:**
1. Install PostgreSQL on the machine
2. Run the deployment script:
   ```powershell
   .\Deploy-ToIIS.ps1
   ```

### Scenario 2: Separate Database Server
Database on one machine, web application on another (or multiple) machine(s).

**Steps:**

#### On the Database Server:
1. Install PostgreSQL
2. Configure it for network access:
   ```powershell
   .\Configure-PostgreSQLNetwork.ps1
   ```
3. Note the server's IP address (displayed by the script)

#### On Each Web Server:
1. Run the deployment script with database server IP:
   ```powershell
   .\Deploy-ToIIS.ps1 -DatabaseServer "192.168.1.100"
   ```

### Scenario 3: Multiple Web Servers (Load Balanced)
Multiple web servers connecting to a single database server.

**Steps:**

#### On the Database Server:
1. Configure PostgreSQL for network access (as above)

#### On Each Web Server:
1. Run deployment script with the database server IP:
   ```powershell
   .\Deploy-ToIIS.ps1 `
	   -DatabaseServer "192.168.1.100" `
	   -SiteName "WordManipulation" `
	   -Port 8080
   ```

2. (Optional) Configure load balancer to distribute traffic across all web servers

---

## Detailed Deployment Instructions

### Step 1: Prepare the Database Server

1. **Install PostgreSQL** (if not already installed):
   - Download from: https://www.postgresql.org/download/windows/
   - During installation, note the password for the `postgres` user
   - Default port is 5432

2. **Configure Network Access**:
   ```powershell
   # Run as Administrator
   .\Configure-PostgreSQLNetwork.ps1 -AllowedNetworkCIDR "192.168.1.0/24"
   ```

   Replace `192.168.1.0/24` with your network's CIDR notation:
   - `192.168.1.0/24` allows 192.168.1.0 - 192.168.1.255
   - `10.0.0.0/8` allows all 10.x.x.x addresses
   - `0.0.0.0/0` allows all IPs (not recommended for production)

3. **Verify the connection**:
   ```powershell
   # From another machine
   Test-NetConnection -ComputerName <DB_SERVER_IP> -Port 5432
   ```

### Step 2: Deploy to Web Server(s)

1. **Copy the deployment files** to each web server:
   - `Deploy-ToIIS.ps1`
   - The entire application source code folder

2. **Run the deployment script** as Administrator:
   ```powershell
   # Basic deployment (local database)
   .\Deploy-ToIIS.ps1

   # Deployment with custom settings
   .\Deploy-ToIIS.ps1 `
	   -SiteName "WordManipulation" `
	   -Port 8080 `
	   -DatabaseServer "192.168.1.100" `
	   -DatabaseName "WordManipulationDb" `
	   -DatabaseUser "postgres" `
	   -DatabasePassword "your_secure_password"
   ```

3. **The script will automatically**:
   - Install IIS and required features
   - Create an application pool
   - Publish the application
   - Deploy files to IIS
   - Configure connection strings
   - Set up firewall rules
   - Start the website

### Step 3: Verify Deployment

1. **On the web server**, open a browser:
   ```
   http://localhost:8080
   ```

2. **From another machine** on the network:
   ```
   http://<WEB_SERVER_IP>:8080
   ```

3. **Check the admin panel**:
   ```
   http://<WEB_SERVER_IP>:8080/Admin
   ```

---

## Script Parameters

### Deploy-ToIIS.ps1

| Parameter | Description | Default |
|-----------|-------------|---------|
| `-SiteName` | IIS website name | WordManipulation |
| `-AppPoolName` | IIS application pool name | WordManipulationAppPool |
| `-PhysicalPath` | Physical path for deployed files | C:\inetpub\wwwroot\WordManipulation |
| `-Port` | HTTP port | 8080 |
| `-HostName` | Optional hostname for binding | (empty) |
| `-DatabaseServer` | PostgreSQL server address | localhost |
| `-DatabaseName` | Database name | WordManipulationDb |
| `-DatabaseUser` | Database username | postgres |
| `-DatabasePassword` | Database password | pwd |

### Configure-PostgreSQLNetwork.ps1

| Parameter | Description | Default |
|-----------|-------------|---------|
| `-PostgresDataPath` | Path to PostgreSQL data directory | C:\Program Files\PostgreSQL\15\data |
| `-AllowedNetworkCIDR` | Network CIDR to allow connections from | 192.168.1.0/24 |

---

## Network Configuration

### Firewall Ports

The following ports need to be open:

| Port | Service | Direction |
|------|---------|-----------|
| 5432 | PostgreSQL | Inbound on DB server |
| 8080 | Web Application | Inbound on web servers |

The deployment scripts automatically configure Windows Firewall rules.

### Network Requirements

- All web servers must be able to reach the database server on port 5432
- Client machines must be able to reach web servers on port 8080
- Ensure corporate firewalls allow these connections

---

## Common Deployment Patterns

### Pattern 1: Development/Small Office
```
┌──────────────────────┐
│   Single Machine     │
│                      │
│  ┌────────────┐     │
│  │  IIS Web   │     │
│  │    App     │     │
│  └─────┬──────┘     │
│        │            │
│  ┌─────▼──────┐     │
│  │ PostgreSQL │     │
│  └────────────┘     │
└──────────────────────┘
```

**Command:**
```powershell
.\Deploy-ToIIS.ps1
```

### Pattern 2: Small Business
```
┌──────────────┐         ┌──────────────┐
│  Web Server  │         │  DB Server   │
│              │         │              │
│  ┌────────┐ │         │ ┌──────────┐ │
│  │IIS Web │ ├────────>│ │PostgreSQL│ │
│  │  App   │ │         │ └──────────┘ │
│  └────────┘ │         │              │
└──────────────┘         └──────────────┘
```

**Commands:**

On DB Server:
```powershell
.\Configure-PostgreSQLNetwork.ps1
```

On Web Server:
```powershell
.\Deploy-ToIIS.ps1 -DatabaseServer "192.168.1.100"
```

### Pattern 3: Enterprise/High Availability
```
┌──────────────┐
│  Web Server  │──┐
│     #1       │  │
└──────────────┘  │
				  │     ┌──────────────┐
┌──────────────┐  │     │  DB Server   │
│  Web Server  │──┼────>│              │
│     #2       │  │     │ ┌──────────┐ │
└──────────────┘  │     │ │PostgreSQL│ │
				  │     │ └──────────┘ │
┌──────────────┐  │     └──────────────┘
│  Web Server  │──┘
│     #3       │
└──────────────┘
```

**Commands:**

On DB Server:
```powershell
.\Configure-PostgreSQLNetwork.ps1 -AllowedNetworkCIDR "10.0.0.0/8"
```

On Each Web Server:
```powershell
.\Deploy-ToIIS.ps1 `
	-DatabaseServer "10.0.1.100" `
	-DatabasePassword "SecurePassword123"
```

---

## Troubleshooting

### Issue: Can't connect to database from web server

**Check:**
1. Database server firewall allows port 5432
2. PostgreSQL is configured to listen on all interfaces
3. pg_hba.conf allows connections from web server IP
4. Test connection:
   ```powershell
   Test-NetConnection -ComputerName <DB_SERVER_IP> -Port 5432
   ```

### Issue: Website shows 503 error

**Check:**
1. Application pool is started
2. ASP.NET Core Hosting Bundle is installed
3. Check Windows Event Viewer → Application logs
4. Check IIS logs in `C:\inetpub\logs\LogFiles\`

### Issue: Can't access website from other machines

**Check:**
1. Windows Firewall allows port 8080
2. Test from client:
   ```powershell
   Test-NetConnection -ComputerName <WEB_SERVER_IP> -Port 8080
   ```
3. Corporate firewall allows connections
4. IIS binding is set to `*` (all IPs) not just `localhost`

### Issue: Database migration fails

**Solution:**
```powershell
# On the web server, navigate to the published folder
cd C:\inetpub\wwwroot\WordManipulation

# Run migration manually
dotnet ef database update --connection "Host=<DB_IP>;Database=WordManipulationDb;Username=postgres;Password=<pass>"
```

---

## Updating the Application

To update an existing deployment:

1. Stop the IIS website (optional, but recommended):
   ```powershell
   Stop-IISSite -Name "WordManipulation"
   ```

2. Re-run the deployment script:
   ```powershell
   .\Deploy-ToIIS.ps1 -DatabaseServer "192.168.1.100"
   ```

3. The script will:
   - Stop the site automatically
   - Publish the latest code
   - Replace files
   - Restart the site

---

## Security Recommendations

1. **Database Password**: Change the default PostgreSQL password
2. **Firewall**: Restrict access to only necessary IPs
3. **HTTPS**: Configure SSL/TLS certificates for production
4. **Application Pool Identity**: Use a dedicated service account
5. **File Permissions**: Ensure IIS has minimum required permissions
6. **Network Isolation**: Place database server in a separate network segment

---

## Performance Tuning

### For the Database Server:
- Increase PostgreSQL `max_connections` if using multiple web servers
- Configure `shared_buffers` (typically 25% of RAM)
- Enable query logging for monitoring

### For Web Servers:
- Adjust IIS application pool settings:
  - `Maximum Worker Processes`: Set to number of CPU cores
  - `Queue Length`: Increase if handling many requests
- Enable IIS output caching
- Consider using a reverse proxy (like ARR) for load balancing

---

## Monitoring

### Check Application Pool Status:
```powershell
Get-WebAppPoolState -Name "WordManipulationAppPool"
```

### Check Website Status:
```powershell
Get-Website -Name "WordManipulation"
```

### View Recent IIS Logs:
```powershell
Get-Content "C:\inetpub\logs\LogFiles\W3SVC*\*.log" -Tail 50
```

### Monitor PostgreSQL Connections:
```sql
SELECT * FROM pg_stat_activity;
```

---

## Additional Resources

- [IIS Documentation](https://docs.microsoft.com/iis/)
- [ASP.NET Core Hosting](https://docs.microsoft.com/aspnet/core/host-and-deploy/iis/)
- [PostgreSQL Documentation](https://www.postgresql.org/docs/)

---

## Support

For issues with the deployment scripts, check:
1. Script output messages
2. Windows Event Viewer
3. IIS Manager → Sites → WordManipulation → Browse
4. PostgreSQL logs

---

## Quick Reference Commands

```powershell
# Deploy locally
.\Deploy-ToIIS.ps1

# Deploy with remote database
.\Deploy-ToIIS.ps1 -DatabaseServer "192.168.1.100"

# Deploy with custom port
.\Deploy-ToIIS.ps1 -Port 80

# Deploy with all custom settings
.\Deploy-ToIIS.ps1 `
	-SiteName "MyApp" `
	-Port 8080 `
	-DatabaseServer "db.company.local" `
	-DatabasePassword "SecurePass123"

# Configure database for network
.\Configure-PostgreSQLNetwork.ps1

# Check deployment status
Get-Website -Name "WordManipulation"
Get-WebAppPoolState -Name "WordManipulationAppPool"

# Restart website
Restart-WebAppPool -Name "WordManipulationAppPool"
Stop-Website -Name "WordManipulation"
Start-Website -Name "WordManipulation"
```
