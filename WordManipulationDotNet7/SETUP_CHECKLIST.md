# ✅ Quick Docker Setup Checklist

## Right Now - Do These Steps in Order:

### ☐ Step 1: Install Docker Desktop
1. Go to: https://www.docker.com/products/docker-desktop
2. Download Docker Desktop for Windows
3. Install it (accept all defaults)
4. **Restart your computer**
5. Wait for Docker Desktop to start (check system tray icon)

### ☐ Step 2: Verify Docker Works
Open PowerShell and run:
```powershell
docker --version
```
✅ Should show: `Docker version 24.x.x`

### ☐ Step 3: Start PostgreSQL Container
```powershell
docker run --name postgres-word -e POSTGRES_PASSWORD=pwd -p 5432:5432 -d postgres:16
```
✅ Should download image and start container

### ☐ Step 4: Wait 10 Seconds
PostgreSQL needs a moment to initialize

### ☐ Step 5: Apply Migration
```powershell
cd "C:\Users\bmich\source\repos\KostasMihawk\WordManipulationDotNet7\WordManipulationDotNet7"
dotnet ef database update
```
✅ Should see: "Applying migration... Done."

### ☐ Step 6: Run Your App
```powershell
dotnet run
```

### ☐ Step 7: Test Admin Page
Open browser: `https://localhost:5001/Admin`
✅ Should load instantly with dashboard!

---

## 🎯 One-Liner After Docker is Installed

```powershell
docker run --name postgres-word -e POSTGRES_PASSWORD=pwd -p 5432:5432 -d postgres:16 ; Start-Sleep 10 ; cd "C:\Users\bmich\source\repos\KostasMihawk\WordManipulationDotNet7\WordManipulationDotNet7" ; dotnet ef database update ; dotnet run
```

Copy this entire command and paste it in PowerShell after Docker Desktop is running!

---

## ⏱️ Time Estimate

- Docker Desktop download: ~5 minutes
- Docker Desktop install: ~2 minutes
- Computer restart: ~2 minutes
- PostgreSQL container start: ~30 seconds
- Migration: ~10 seconds
- **Total: ~10 minutes**

---

## 📞 Tell Me When...

**Message me when you've:**
1. ✅ Installed Docker Desktop
2. ✅ Restarted your computer
3. ✅ Verified `docker --version` works

**Then I'll help with the next steps!**

---

## 🆘 If Something Goes Wrong

**Docker won't start?**
→ Make sure virtualization is enabled in BIOS
→ Windows 10/11 Home needs WSL2

**Can't download Docker?**
→ Try different browser
→ Disable antivirus temporarily

**Docker installed but commands don't work?**
→ Restart PowerShell
→ Make sure Docker Desktop is running (check system tray)

---

**Your appsettings.json already has the correct password: `pwd` ✅**
**Your connection string is ready: `Host=localhost;...` ✅**
**You just need Docker! 🐳**
