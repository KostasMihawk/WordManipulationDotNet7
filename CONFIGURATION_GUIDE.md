# Configuration Guide

## appsettings.json Configuration Reference

### Company Settings
Update these values to match your company information:

```json
"CompanySettings": {
  "Name": "Your Company Name",
  "Address": "Your Street Address",
  "City": "Your City",
  "PostalCode": "Postal Code",
  "TaxId": "Your Tax ID",
  "TaxOffice": "Your Tax Office",
  "Phone": "Main Phone",
  "Phone1": "Contact Person 1 Phone",
  "Phone2": "Contact Person 2 Phone",
  "Email": "company@email.com"
}
```

### Document Settings
Customize document formatting:

```json
"DocumentSettings": {
  "DefaultFontSize": 12,              // Font size in points
  "DefaultFontFamily": "Times New Roman", // Font family name
  "LineSpacing": 1.2                  // Line spacing multiplier
}
```

### Pricing Settings
Update pricing for different zones:

```json
"PricingSettings": {
  "ZoneAPrice": 35.00,    // Zone A base price
  "ZoneBPrice": 55.00,    // Zone B base price
  "ZoneCPrice": 73.00,    // Zone C base price
  "TaxRate": 0.24         // Tax rate (0.24 = 24%)
}
```

**Note**: Tax and total are automatically calculated:
- Tax = Price × TaxRate
- Total = Price + Tax

### Logging Settings
Configure where and how logs are stored:

```json
"Serilog": {
  "MinimumLevel": {
    "Default": "Information",  // Minimum log level: Verbose, Debug, Information, Warning, Error, Fatal
    "Override": {
      "Microsoft": "Warning",
      "System": "Warning"
    }
  },
  "WriteTo": [
    { "Name": "Console" },
    {
      "Name": "File",
      "Args": {
        "path": "Logs/log-.txt",           // Log file path pattern
        "rollingInterval": "Day",           // New file daily
        "retainedFileCountLimit": 30        // Keep 30 days of logs
      }
    }
  ]
}
```

## Environment-Specific Configuration

### Development (appsettings.Development.json)
Create this file for development-specific settings:

```json
{
  "Serilog": {
    "MinimumLevel": {
      "Default": "Debug"
    }
  },
  "PricingSettings": {
    "ZoneAPrice": 1.00,  // Lower prices for testing
    "ZoneBPrice": 2.00,
    "ZoneCPrice": 3.00
  }
}
```

### Production
Use the main `appsettings.json` for production values.

## Deployment Checklist

Before deploying:

- [ ] Update CompanySettings with correct company information
- [ ] Verify PricingSettings match current rates
- [ ] Ensure log directory has write permissions
- [ ] Test document generation for each document type
- [ ] Verify all Greek characters display correctly
- [ ] Check timezone settings for date/time operations

## Log Files

Logs are written to `Logs/log-yyyyMMdd.txt`

Example: `Logs/log-20250119.txt`

To change log location, update the `path` in Serilog configuration.

## Common Tasks

### Change Company Name
Edit `CompanySettings.Name` in `appsettings.json`

### Update Pricing
Edit the respective `ZoneXPrice` value in `PricingSettings`

### Change Tax Rate
Edit `PricingSettings.TaxRate` (e.g., 0.24 for 24%, 0.20 for 20%)

### Increase Log Retention
Change `retainedFileCountLimit` in Serilog configuration

### Change Font
Update `DocumentSettings.DefaultFontFamily`

## Troubleshooting

### Logs not appearing
- Check directory permissions for `Logs` folder
- Verify Serilog configuration is correct
- Check minimum log level isn't set too high

### Wrong pricing in documents
- Verify PricingSettings in appsettings.json
- Check TaxRate is decimal (0.24 not 24)
- Restart application after configuration changes

### Company information not updating
- Ensure appsettings.json is being deployed
- Restart application
- Check for appsettings.{Environment}.json overrides

---

For more details, see `IMPROVEMENTS_SUMMARY.md`
