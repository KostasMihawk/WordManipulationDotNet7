# 🚀 Quick Diagnostic Commands - Run These NOW

## ⚡ Step-by-Step Diagnosis (5 minutes)

Copy and paste these commands in order:

---

## Step 1: Check if App is Running

**Look at your terminal/console:**
Should see:
```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:5001
```

**If you DON'T see this:**
```powershell
# Start the app
dotnet run
```

---

## Step 2: Check PostgreSQL Status

**Windows PowerShell:**
```powershell
Get-Service | Where-Object {$_.Name -like "*postgres*"}
```

**Expected output:**
```
Status   Name               DisplayName
------   ----               -----------
Running  postgresql-x64-16  PostgreSQL Server 16
```

**If STOPPED:**
```powershell
Start-Service postgresql-x64-16
```

**Docker (if using Docker):**
```bash
docker ps | grep postgres
```

**If not running:**
```bash
docker start postgres-word
```

---

## Step 3: Test Database Connection

```powershell
# Test if database exists
psql -U postgres -c "\l" | Select-String "WordManipulationDb"
```

**Expected:** Should show WordManipulationDb in the list

**If database doesn't exist:**
```powershell
dotnet ef database update
```

---

## Step 4: Test URLs in Browser

Open these URLs **one by one** and note what happens:

### Test 4.1: Home Page
```
https://localhost:5001
```
**Expected:** Home page loads ✅

### Test 4.2: Diagnostics (Simple)
```
https://localhost:5001/Diagnostics
```
**Expected:** Text "Diagnostics controller is working" ✅

### Test 4.3: Diagnostics View
```
https://localhost:5001/Diagnostics/TestView
```
**Expected:** Diagnostic test page with links ✅

### Test 4.4: Admin Simple Test
```
https://localhost:5001/Admin/Test
```
**Expected:** Text "Admin controller is working!" ✅

### Test 4.5: Admin Dashboard
```
https://localhost:5001/Admin
```
**Expected:** Admin dashboard with cards ✅

---

## Step 5: Check Browser Console

1. Open browser
2. Press **F12**
3. Click **Console** tab
4. Try loading `https://localhost:5001/Admin`
5. **Screenshot any red errors**

---

## Step 6: Check Network Tab

1. Still in F12
2. Click **Network** tab  
3. Reload the page
4. Look for:
   - ❌ Red items (failed requests)
   - ⏳ Items stuck on "pending"

---

## 📊 Collect This Information

Run these and save the output:

### System Info:
```powershell
# .NET version
dotnet --version

# PostgreSQL version (Windows)
Get-ItemProperty "HKLM:\SOFTWARE\PostgreSQL\Installations\postgresql-x64-16" -ErrorAction SilentlyContinue | Select-Object -ExpandProperty Version

# PostgreSQL version (Docker)
docker exec postgres-word postgres --version
```

### Database Info:
```powershell
# Count records
psql -U postgres -d WordManipulationDb -c "SELECT 'Baillifs' as table, COUNT(*) FROM \"Baillifs\" UNION ALL SELECT 'Attorneys', COUNT(*) FROM \"Attorneys\";"
```

### App Configuration:
```powershell
# Check if appsettings.json exists
Test-Path ".\appsettings.json"

# Show connection string (hide password)
Get-Content ".\appsettings.json" | Select-String "DefaultConnection"
```

---

## 🎯 Most Likely Issues & Quick Fixes

### Issue 1: "Page keeps loading forever"

**Diagnosis:**
```powershell
# Check if database queries are slow
psql -U postgres -d WordManipulationDb -c "SELECT COUNT(*) FROM \"Baillifs\";"
```

**If this hangs:**
→ Database connection issue

**Fix:**
```powershell
# Restart PostgreSQL
Restart-Service postgresql-x64-16

# Then restart app
dotnet run
```

---

### Issue 2: "Blank white page"

**Check browser console** (F12)

**If you see JavaScript errors:**
→ Static files not loading

**Fix:**
- Hard refresh: `Ctrl + Shift + R`
- Clear cache: `Ctrl + Shift + Delete`

---

### Issue 3: "404 Not Found"

**Check URL spelling:**
- ✅ Correct: `https://localhost:5001/Admin`
- ❌ Wrong: `https://localhost:5001/admin` (lowercase might not work)
- ❌ Wrong: `https://localhost:5001/Admin/Index.cshtml`

**Try:**
```
https://localhost:5001/Admin/Test
```

**If this works:**
→ View file issue

**Fix:**
```powershell
# Check if view exists
Test-Path ".\Views\Admin\Index.cshtml"
```

---

### Issue 4: "Can't connect to database"

**Test connection:**
```powershell
psql -h localhost -U postgres -d WordManipulationDb -c "SELECT 1;"
```

**If fails with password error:**

**Fix appsettings.json:**
```json
"DefaultConnection": "Host=localhost;Database=WordManipulationDb;Username=postgres;Password=YOUR_ACTUAL_PASSWORD"
```

---

## 🔍 Advanced Diagnostics

### Enable detailed logging:

**Edit appsettings.json**, add:
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information",
      "Microsoft.EntityFrameworkCore.Database.Command": "Information"
    }
  }
}
```

**Then run:**
```powershell
dotnet run
```

**Look for SQL queries in console:**
```
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (5ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT COUNT(*) FROM "Baillifs"
```

**If you see these:**
→ Database connection is working

**If you DON'T see these when loading /Admin:**
→ Code isn't reaching the database query

---

## 📸 What to Screenshot

If you need to report the issue:

1. **Browser showing the stuck page**
2. **Browser console (F12 → Console)** showing errors
3. **Browser network tab (F12 → Network)** showing pending requests
4. **Terminal/console** showing server logs
5. **Services window** showing PostgreSQL status

---

## ⚡ Nuclear Option (Last Resort)

**Complete reset:**
```powershell
# 1. Stop app (Ctrl+C)

# 2. Drop database
psql -U postgres -c "DROP DATABASE IF EXISTS WordManipulationDb;"

# 3. Recreate database
psql -U postgres -c "CREATE DATABASE WordManipulationDb;"

# 4. Clean solution
dotnet clean

# 5. Remove migrations (backup first!)
Remove-Item -Recurse -Force .\Migrations

# 6. Create fresh migration
dotnet ef migrations add InitialCreate

# 7. Apply migration
dotnet ef database update

# 8. Run app
dotnet run
```

---

## 📝 Quick Report Template

Copy this and fill in the blanks:

```
## Issue Report

**What I see:**
[blank page / loading spinner / error message / other]

**Diagnostic Results:**
- Home page (/) works: [YES/NO]
- Diagnostics (/Diagnostics) works: [YES/NO]
- Admin Test (/Admin/Test) works: [YES/NO]
- Admin Dashboard (/Admin) works: [YES/NO]

**PostgreSQL Status:**
[Running / Stopped / Not Installed]

**Browser Console Errors:**
[Paste errors or "None"]

**Server Console Output:**
[Paste last 20 lines or "No errors"]

**Connection String (hide password):**
[Paste from appsettings.json with *** for password]

**What I've tried:**
- [ ] Hard refresh (Ctrl+Shift+R)
- [ ] Different browser
- [ ] Restarted app
- [ ] Restarted PostgreSQL
- [ ] Cleared browser cache
```

---

**Start with the URL tests in Step 4. Report which URLs work and which don't!**
