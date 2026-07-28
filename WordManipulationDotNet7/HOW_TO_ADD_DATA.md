# How to Add New Objects to the Database

This guide shows you **4 different ways** to add new data to your PostgreSQL database.

## 🚀 Method 1: Using the Admin Web Interface (EASIEST)

### Just Created! Access at:
```
https://localhost:5001/Admin
```

### Features:
- ✅ **Bailiffs Management** - Add/Delete bailiffs
- ✅ **Attorneys Management** - Add/Delete attorneys, notaries
- ✅ **Funds Management** - Add/Delete funds
- 📊 **Dashboard** - See all record counts

### Usage:
1. Run your application
2. Navigate to `/Admin`
3. Click on the entity type you want to manage
4. Fill in the form and click "Προσθήκη"
5. Data is immediately available in dropdowns!

**Perfect for non-technical users!**

---

## 🗄️ Method 2: Direct SQL (FOR QUICK ADDITIONS)

### Using pgAdmin, DBeaver, or psql:

**Connect:**
- Host: `localhost`
- Database: `WordManipulationDb`
- Username: `postgres`
- Password: (your password)

**Then execute SQL:**

### Add a Bailiff
```sql
INSERT INTO "Baillifs" ("Id", "Name", "City", "AFM")
VALUES (
    (SELECT COALESCE(MAX("Id"), 0) + 1 FROM "Baillifs"),
    'Νέος Επιμελητής',
    'Θεσσαλονίκη',
    '123456789'
);
```

### Add an Attorney (ID 200+ for GetAttorneysList)
```sql
INSERT INTO "Attorneys" ("Id", "Name", "City", "Pronoun", "Description", "GiaSunexisi")
VALUES (
    (SELECT COALESCE(MAX("Id"), 199) + 1 FROM "Attorneys" WHERE "Id" >= 200),
    'Νέος Δικηγόρος',
    'Πάτρα',
    'του',
    'Περιγραφή εδώ',
    'Για συνέχιση εδώ'
);
```

### Add a Notary (ID 1-99 for GetNotaries)
```sql
INSERT INTO "Attorneys" ("Id", "Name", "City", "Pronoun", "Description", "GiaSunexisi")
VALUES (
    (SELECT COALESCE(MAX("Id"), 0) + 1 FROM "Attorneys" WHERE "Id" < 100),
    'Νέος Συμβολαιογράφος',
    'Αθήνα',
    'της',
    'της συμβολαιογράφου...',
    'Για συνέχιση εδώ'
);
```

### Add a Notary (New) (ID 100-199 for GetNotariesNew)
```sql
INSERT INTO "Attorneys" ("Id", "Name", "City", "Pronoun", "Description", "GiaSunexisi")
VALUES (
    (SELECT COALESCE(MAX("Id"), 99) + 1 FROM "Attorneys" WHERE "Id" >= 100 AND "Id" < 200),
    'Νέος Συμβολαιογράφος (New)',
    'Αθήνα',
    'της',
    'Περιγραφή...',
    'Για συνέχιση εδώ'
);
```

### Add a Fund
```sql
INSERT INTO "Funds" ("Id", "Name", "Description", "MAEDAP", "MAEDAPAdress")
VALUES (
    (SELECT COALESCE(MAX("Id"), 0) + 1 FROM "Funds"),
    'NEW FUND DESIGNATED ACTIVITY COMPANY',
    'με έδρα το Δουβλίνο Ιρλανδίας',
    'MAEDAP NAME HERE',
    'Διεύθυνση MAEDAP'
);
```

### Add a Zone
```sql
INSERT INTO "Zones" ("Id", "Name", "Value", "Tax", "TaxedValue")
VALUES (
    (SELECT COALESCE(MAX("Id"), 0) + 1 FROM "Zones"),
    'Ε',
    120.00,
    28.80,
    148.80
);
```

### Add a Bank
```sql
INSERT INTO "Banks" ("Id", "Name", "DiakritikosTitlos", "Edra", "AFM")
VALUES (
    (SELECT COALESCE(MAX("Id"), 0) + 1 FROM "Banks"),
    'ΝΕΑ ΤΡΑΠΕΖΑ',
    'Διακριτικός Τίτλος',
    'που εδρεύει στην...',
    '999888777'
);
```

### Add a Debtor
```sql
INSERT INTO "DebtorsForSunexisi" ("Id", "Name", "Description")
VALUES (
    (SELECT COALESCE(MAX("Id"), 0) + 1 FROM "DebtorsForSunexisi"),
    'Νέος Οφειλέτης',
    'Περιγραφή του οφειλέτη...'
);
```

**Perfect for bulk additions or scripting!**

---

## 📝 Method 3: Update DbSeeder.cs (FOR PERMANENT DEFAULT DATA)

If you want data to be included in the initial seed:

### 1. Open `Data/DbSeeder.cs`

### 2. Find the appropriate method (e.g., `GetBaillifs()`)

### 3. Add your data:
```csharp
private static List<Baillif> GetBaillifs()
{
    var id = 1;
    var list = new List<Baillif>();
    
    // Existing baillifs...
    list.Add(new Baillif
    {
        Id = id++,
        Name = "Παρασκευή A. Μιχοπούλου",
        City = "Αθήνα",
        AFM = "152255360"
    });
    
    // ADD YOUR NEW ONE HERE
    list.Add(new Baillif
    {
        Id = id++,
        Name = "Νέος Επιμελητής",
        City = "Θεσσαλονίκη",
        AFM = "999888777"
    });
    
    return list;
}
```

### 4. Reset the database:
```bash
# Connect to PostgreSQL
psql -U postgres

# Drop database
DROP DATABASE WordManipulationDb;
\q

# Run application - it will recreate with new data
dotnet run
```

**Perfect for permanent default data!**

---

## 💻 Method 4: Programmatically in Code (FOR ADVANCED SCENARIOS)

Create a service or use DbContext directly:

```csharp
public class DataService
{
    private readonly ApplicationDbContext _context;

    public DataService(ApplicationDbContext context)
    {
        _context = context;
    }

    public void AddBaillif(string name, string city, string afm)
    {
        var maxId = _context.Baillifs.Any() 
            ? _context.Baillifs.Max(b => b.Id) 
            : 0;

        var baillif = new Baillif
        {
            Id = maxId + 1,
            Name = name,
            City = city,
            AFM = afm
        };

        _context.Baillifs.Add(baillif);
        _context.SaveChanges();
    }

    public void AddAttorney(string name, string city, string pronoun, 
                           string description, string giaSunexisi, 
                           AttorneyType type)
    {
        var id = type switch
        {
            AttorneyType.Notary => _context.Attorneys.Where(a => a.Id < 100).Max(a => a.Id) + 1,
            AttorneyType.NotaryNew => _context.Attorneys.Where(a => a.Id >= 100 && a.Id < 200).Max(a => a.Id) + 1,
            AttorneyType.Attorney => _context.Attorneys.Where(a => a.Id >= 200).Max(a => a.Id) + 1,
            _ => 200
        };

        var attorney = new Attorney
        {
            Id = id,
            Name = name,
            City = city,
            Pronoun = pronoun,
            Description = description,
            GiaSunexisi = giaSunexisi
        };

        _context.Attorneys.Add(attorney);
        _context.SaveChanges();
    }
}

public enum AttorneyType
{
    Notary,      // IDs 1-99
    NotaryNew,   // IDs 100-199
    Attorney     // IDs 200+
}
```

**Perfect for automation or API endpoints!**

---

## 🎯 Quick Reference: Attorney ID Ranges

| Range | Method | Usage |
|-------|--------|-------|
| **1-99** | `GetNotaries()` | Original Notaries |
| **100-199** | `GetNotariesNew()` | New Notaries |
| **200+** | `GetAttorneysList()` | Attorneys |

---

## 📊 View All Data

```sql
-- Count all records
SELECT 'Baillifs' as "Table", COUNT(*) as "Count" FROM "Baillifs"
UNION ALL
SELECT 'Attorneys', COUNT(*) FROM "Attorneys"
UNION ALL
SELECT 'Funds', COUNT(*) FROM "Funds"
UNION ALL
SELECT 'Zones', COUNT(*) FROM "Zones"
UNION ALL
SELECT 'Banks', COUNT(*) FROM "Banks"
UNION ALL
SELECT 'Debtors', COUNT(*) FROM "DebtorsForSunexisi";

-- View all data
SELECT * FROM "Baillifs";
SELECT * FROM "Attorneys" ORDER BY "Id";
SELECT * FROM "Funds";
SELECT * FROM "Zones";
SELECT * FROM "Banks";
```

---

## ✅ Recommended Approach

**For most users:**
1. Use the **Admin Web Interface** (`/Admin`) for day-to-day additions
2. Use **SQL** for bulk operations or importing data
3. Use **DbSeeder** for permanent default data
4. Use **Code** for automated processes

---

## 🆘 Troubleshooting

### Data doesn't appear in dropdowns
- ✅ Refresh the page
- ✅ Check data was saved: `SELECT * FROM "TableName";`
- ✅ Verify IDs are in correct range for attorneys

### Duplicate ID error
- ✅ Use the auto-increment queries provided above
- ✅ Don't manually set IDs - let the query calculate them

### Changes lost after restart
- ✅ If using DbSeeder, the seeder only runs if database is empty
- ✅ Use SQL or Admin interface for persistent changes

---

## 📚 Additional Resources

- See `SQL_QUERIES.sql` for more query examples
- See `DATABASE_SETUP.md` for detailed database info
- Admin pages created in `Pages/Admin/` folder

---

**Happy Data Management! 🎉**
