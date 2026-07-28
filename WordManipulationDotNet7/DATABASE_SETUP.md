# Database Setup Guide

## Overview
This application now uses **PostgreSQL** as the database with **Entity Framework Core** for data access.

## Prerequisites
1. PostgreSQL Server installed (version 12 or higher recommended)
2. .NET 8.0 SDK
3. Entity Framework Core CLI tools

## Database Configuration

### 1. Connection String
Update the connection string in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=WordManipulationDb;Username=postgres;Password=your_password_here"
}
```

**Important**: Replace `your_password_here` with your actual PostgreSQL password.

### 2. Create Database
The database will be created automatically when you run the application for the first time, or you can create it manually:

```bash
# Run migrations
dotnet ef database update
```

## Database Schema

The application includes the following tables:

### Baillifs
Stores bailiff (δικαστικός επιμελητής) information
- Id (Primary Key)
- Name
- City
- AFM (Tax ID)

### Attorneys
Stores attorney and notary information
- Id (Primary Key)
- Name
- City
- Pronoun
- Description
- GiaSunexisi

### Funds
Stores fund company information
- Id (Primary Key)
- Name
- Description
- MAEDAP
- MAEDAPAdress

### Zones
Stores pricing zone information
- Id (Primary Key)
- Name
- Value
- Tax
- TaxedValue

### EkthesiEpidoshsModels
Stores template document information
- Id (Primary Key)
- Location
- Name
- Perigrafh
- Praxh
- FusikoProswpo
- Kleisimo
- HasKleisimo
- Signature
- ZoneB
- PriorityNumber

### DebtorsForSunexisi
Stores debtor information for continuation proceedings
- Id (Primary Key)
- Name
- Description

### Banks
Stores banking institution information (PistotikaIdrymataUpoEkkatharisi)
- Id (Primary Key)
- Name
- DiakritikosTitlos
- Edra
- AFM

## Seeded Data

The database comes pre-seeded with:
- 3 Bailiffs
- Multiple Attorneys (categorized by ID ranges):
  - IDs 1-99: Notaries
  - IDs 100-199: Notaries (New)
  - IDs 200+: Attorneys
- Multiple Funds (GALAXY, FRONTIER, etc.)
- 8 Zones (Α, Β, Γ, Δ and their 20% variants)
- Document templates for various proceedings
- Sample debtors and banks

## Entity Framework Migrations

### Create a new migration
```bash
dotnet ef migrations add MigrationName
```

### Apply migrations
```bash
dotnet ef database update
```

### Rollback to a specific migration
```bash
dotnet ef database update PreviousMigrationName
```

### Remove last migration
```bash
dotnet ef migrations remove
```

## Usage in Code

### Accessing Data via DropDownGeneratorDb

The `DropDownGeneratorDb` class provides methods to retrieve data from the database:

```csharp
public class MyController : Controller
{
    private readonly DropDownGeneratorDb _dropDownGenerator;

    public MyController(DropDownGeneratorDb dropDownGenerator)
    {
        _dropDownGenerator = dropDownGenerator;
    }

    public IActionResult Index()
    {
        var baillifs = _dropDownGenerator.GetBaillifs();
        var attorneys = _dropDownGenerator.GetAttorneysList();
        var zones = _dropDownGenerator.GetZones();
        // ... use the data
    }
}
```

### Available Methods

- `GetBaillifs()` - Returns all bailiffs
- `GetNotaries()` - Returns notaries (IDs 1-99)
- `GetNotariesNew()` - Returns new notaries (IDs 100-199)
- `GetAttorneysList()` - Returns attorneys (IDs 200+)
- `GetFunds()` - Returns all funds
- `GetZones()` - Returns all pricing zones
- `GetZipFiles()` - Returns document templates ordered by priority
- `GetDebtorsForSunexisi()` - Returns debtors for continuation proceedings
- `GetBanks()` - Returns banking institutions

## Database Maintenance

### Backup
```bash
pg_dump -U postgres -d WordManipulationDb > backup.sql
```

### Restore
```bash
psql -U postgres -d WordManipulationDb < backup.sql
```

## Troubleshooting

### Connection Issues
1. Ensure PostgreSQL service is running
2. Verify connection string credentials
3. Check if the database exists
4. Verify PostgreSQL is listening on the correct port (default: 5432)

### Migration Issues
1. Delete the `Migrations` folder
2. Drop the database
3. Run `dotnet ef migrations add InitialCreate` again
4. Run `dotnet ef database update`

## Security Notes

1. **Never commit** `appsettings.json` with real passwords to version control
2. Use **User Secrets** for development:
   ```bash
   dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Database=WordManipulationDb;Username=postgres;Password=your_password"
   ```
3. Use **Environment Variables** or **Azure Key Vault** for production

## Future Enhancements

Consider implementing:
- Repository pattern for better abstraction
- Unit of Work pattern for transaction management
- Caching layer for frequently accessed data
- Database migrations in production deployment pipeline
