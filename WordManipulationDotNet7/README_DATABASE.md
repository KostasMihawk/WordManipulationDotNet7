# Quick Start Guide - PostgreSQL Database Integration

## 🎯 What Changed?

Your application now stores all data (bailiffs, attorneys, funds, zones, etc.) in a PostgreSQL database instead of hardcoded lists.

## 🚀 Quick Setup (5 Minutes)

### Step 1: Install PostgreSQL
Choose one option:

**Option A - Windows Installer:**
1. Download from https://www.postgresql.org/download/windows/
2. Run installer (keep default settings)
3. Remember the password you set for 'postgres' user

**Option B - Docker (Recommended for Development):**
```bash
docker run --name postgres-word -e POSTGRES_PASSWORD=MyP@ssw0rd -p 5432:5432 -d postgres:16
```

### Step 2: Update Password
Open `appsettings.json` and change:
```json
"DefaultConnection": "Host=localhost;Database=WordManipulationDb;Username=postgres;Password=your_password_here"
```
to:
```json
"DefaultConnection": "Host=localhost;Database=WordManipulationDb;Username=postgres;Password=YOUR_ACTUAL_PASSWORD"
```

### Step 3: Run Application
```bash
dotnet run
```

That's it! The database will be created and populated automatically on first run.

## ✅ Verify It Works

1. Open browser to `https://localhost:5001`
2. Navigate to any document creation page
3. Check that dropdowns show data (attorneys, zones, etc.)
4. If you see data in dropdowns = Success! ✨

## 🔧 Manage Data

### Using SQL Tool (pgAdmin, DBeaver, etc.)
1. Connect to: `localhost:5432`
2. Database: `WordManipulationDb`
3. Browse tables and edit data

### Using SQL Scripts
Use the queries in `SQL_QUERIES.sql`:

**View all attorneys:**
```sql
SELECT * FROM "Attorneys" ORDER BY "Id";
```

**Add new attorney:**
```sql
INSERT INTO "Attorneys" ("Id", "Name", "City", "Pronoun")
VALUES (300, 'New Attorney', 'Athens', 'του');
```

## 📚 Documentation Files

| File | What's Inside |
|------|---------------|
| **DATABASE_CHECKLIST.md** | Complete checklist of what was done |
| **DATABASE_SETUP.md** | Detailed setup and configuration guide |
| **IMPLEMENTATION_SUMMARY.md** | Technical implementation details |
| **SQL_QUERIES.sql** | Ready-to-use SQL queries |
| **README.md** | This quick start guide |

## 🆘 Common Issues

### "Cannot connect to PostgreSQL"
- ✅ Is PostgreSQL running? Check Services (Windows) or `docker ps` (Docker)
- ✅ Is password correct in `appsettings.json`?

### "Database already exists" error
- ✅ Normal! The app will use existing database
- ✅ To start fresh: `DROP DATABASE WordManipulationDb;` in psql

### "Migration pending" warning
- ✅ Run: `dotnet ef database update`

### "404 Not Found" when accessing `/Admin`
- ✅ **FIXED!** Razor Pages are now enabled in Program.cs
- ✅ Restart your application: `dotnet run`
- ✅ See `ADMIN_404_FIX.md` for details

## 🎓 Learn More

- **Add new data**: Edit `Data/DbSeeder.cs` and restart app
- **Change schema**: Create migration with `dotnet ef migrations add YourMigrationName`
- **Backup data**: `pg_dump -U postgres WordManipulationDb > backup.sql`

## 💡 Pro Tips

1. **Development**: Use Docker for easy cleanup
   ```bash
   docker rm -f postgres-word  # Remove
   docker run --name postgres-word -e POSTGRES_PASSWORD=MyP@ssw0rd -p 5432:5432 -d postgres:16  # Recreate
   ```

2. **Production**: Use proper connection string from environment variables

3. **Testing**: Data is seeded automatically - no manual imports needed!

## 📞 Need Help?

Check the detailed guides:
1. `DATABASE_CHECKLIST.md` - Step-by-step verification
2. `DATABASE_SETUP.md` - Complete configuration guide
3. `IMPLEMENTATION_SUMMARY.md` - Technical details

---

**You're all set! Happy coding! 🎉**
