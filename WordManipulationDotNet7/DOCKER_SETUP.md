# 🐳 Docker PostgreSQL Setup - Quick Guide

## Step 1: Install Docker Desktop (5 minutes)

### Download and Install:
1. **Go to:** https://www.docker.com/products/docker-desktop
2. **Download** Docker Desktop for Windows
3. **Run the installer** - Accept all defaults
4. **Restart your computer** when prompted

### After Restart:
1. **Start Docker Desktop** (it should start automatically)
2. **Wait for Docker to start** - You'll see a Docker icon in the system tray
3. **Wait until the icon stops animating** and shows "Docker Desktop is running"

---

## Step 2: Verify Docker is Running

Open **PowerShell** and run:
```powershell
docker --version
```

**Expected output:**
```
Docker version 24.x.x, build xxxxx
```

---

## Step 3: Start PostgreSQL Container

Copy and paste this command in PowerShell:

```powershell
docker run --name postgres-word -e POSTGRES_PASSWORD=pwd -p 5432:5432 -d postgres:16
```

**What this does:**
- Creates a PostgreSQL container named `postgres-word`
- Sets password to `pwd` (matching your appsettings.json)
- Maps port 5432 (matches your connection string)
- Uses PostgreSQL version 16
- Runs in background (`-d` = detached mode)

**Expected output:**
```
Unable to find image 'postgres:16' locally
16: Pulling from library/postgres
...
Status: Downloaded newer image for postgres:16
[long hash like: a1b2c3d4e5f6...]
```

---

## Step 4: Verify PostgreSQL is Running

```powershell
docker ps
```

**Expected output:**
```
CONTAINER ID   IMAGE         STATUS         PORTS                    NAMES
xxxxx          postgres:16   Up 5 seconds   0.0.0.0:5432->5432/tcp   postgres-word
```

**Look for:**
- ✅ STATUS shows "Up X seconds/minutes"
- ✅ PORTS shows "5432->5432"
- ✅ NAMES shows "postgres-word"

---

## Step 5: Apply Database Migration

Now run these commands **in your project directory**:

```powershell
cd "C:\Users\bmich\source\repos\KostasMihawk\WordManipulationDotNet7\WordManipulationDotNet7"

dotnet ef database update
```

**Expected output:**
```
Build started...
Build succeeded.
Applying migration '20250217xxxxxx_InitialCreate'.
Done.
```

---

## Step 6: Start Your App

```powershell
dotnet run
```

**Then open:** `https://localhost:5001/Admin`

**Expected:** Admin dashboard loads instantly! ✨

---

## 🎯 Common Commands

### Check if PostgreSQL is running:
```powershell
docker ps | Select-String postgres
```

### Start PostgreSQL (if stopped):
```powershell
docker start postgres-word
```

### Stop PostgreSQL:
```powershell
docker stop postgres-word
```

### View PostgreSQL logs:
```powershell
docker logs postgres-word
```

### Restart PostgreSQL:
```powershell
docker restart postgres-word
```

### Remove everything and start fresh:
```powershell
# Stop and remove container
docker stop postgres-word
docker rm postgres-word

# Create new container
docker run --name postgres-word -e POSTGRES_PASSWORD=pwd -p 5432:5432 -d postgres:16
```

---

## 🆘 Troubleshooting

### "Docker command not found"
→ Docker Desktop not installed or not started
→ Restart Docker Desktop

### "port is already allocated"
→ Port 5432 already in use
→ Solution: Stop other PostgreSQL instance or use different port

### "Cannot connect to Docker daemon"
→ Docker Desktop not running
→ Start Docker Desktop from Start Menu

### Container stops immediately
```powershell
# Check logs
docker logs postgres-word
```

---

## ✅ Success Checklist

Before running migration, verify:

```powershell
# 1. Docker is installed
docker --version

# 2. PostgreSQL container is running
docker ps | Select-String postgres

# 3. Container is healthy
docker logs postgres-word --tail 10
```

**Should see:**
```
database system is ready to accept connections
```

---

## 🚀 All-in-One Setup Script

Once Docker Desktop is installed and running, copy/paste this entire block:

```powershell
# Navigate to project
cd "C:\Users\bmich\source\repos\KostasMihawk\WordManipulationDotNet7\WordManipulationDotNet7"

# Start PostgreSQL
docker run --name postgres-word -e POSTGRES_PASSWORD=pwd -p 5432:5432 -d postgres:16

# Wait for PostgreSQL to start
Start-Sleep -Seconds 10

# Apply migration
dotnet ef database update

# Start app
dotnet run
```

Then open: `https://localhost:5001/Admin`

---

## 📋 What Happens Next

After completing these steps:

1. ✅ PostgreSQL running in Docker
2. ✅ Database created (WordManipulationDb)
3. ✅ Tables created (Baillifs, Attorneys, Funds, etc.)
4. ✅ Data seeded automatically
5. ✅ Admin page loads instantly
6. ✅ You can add/manage data

---

**Start with Step 1: Install Docker Desktop, then come back!** 🐳
