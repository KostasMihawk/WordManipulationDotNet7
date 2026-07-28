-- Useful PostgreSQL Queries for WordManipulationDb

-- ============================================
-- VIEW ALL DATA
-- ============================================

-- View all bailiffs
SELECT * FROM "Baillifs" ORDER BY "Id";

-- View all attorneys
SELECT * FROM "Attorneys" ORDER BY "Id";

-- View notaries only (IDs 1-99)
SELECT * FROM "Attorneys" WHERE "Id" BETWEEN 1 AND 99 ORDER BY "Id";

-- View new notaries (IDs 100-199)
SELECT * FROM "Attorneys" WHERE "Id" BETWEEN 100 AND 199 ORDER BY "Id";

-- View attorneys list (IDs 200+)
SELECT * FROM "Attorneys" WHERE "Id" >= 200 ORDER BY "Id";

-- View all funds
SELECT * FROM "Funds" ORDER BY "Id";

-- View all zones
SELECT * FROM "Zones" ORDER BY "Id";

-- View all document templates
SELECT * FROM "EkthesiEpidoshsModels" ORDER BY "PriorityNumber", "Id";

-- View all debtors
SELECT * FROM "DebtorsForSunexisi" ORDER BY "Id";

-- View all banks
SELECT * FROM "Banks" ORDER BY "Id";

-- ============================================
-- ADD NEW DATA
-- ============================================

-- Add a new bailiff
INSERT INTO "Baillifs" ("Id", "Name", "City", "AFM")
VALUES (
    (SELECT COALESCE(MAX("Id"), 0) + 1 FROM "Baillifs"),
    'New Bailiff Name',
    'Athens',
    '123456789'
);

-- Add a new attorney (ID 200+ for attorneys)
INSERT INTO "Attorneys" ("Id", "Name", "City", "Pronoun", "Description", "GiaSunexisi")
VALUES (
    (SELECT COALESCE(MAX("Id"), 199) + 1 FROM "Attorneys" WHERE "Id" >= 200),
    'New Attorney Name',
    'Athens',
    'του',
    'Description here',
    'GiaSunexisi text here'
);

-- Add a new notary (ID 1-99 for original notaries)
INSERT INTO "Attorneys" ("Id", "Name", "City", "Pronoun", "Description", "GiaSunexisi")
VALUES (
    (SELECT COALESCE(MAX("Id"), 0) + 1 FROM "Attorneys" WHERE "Id" < 100),
    'New Notary Name',
    'Athens',
    'της',
    'Notary description',
    'GiaSunexisi text'
);

-- Add a new fund
INSERT INTO "Funds" ("Id", "Name", "Description", "MAEDAP", "MAEDAPAdress")
VALUES (
    (SELECT COALESCE(MAX("Id"), 0) + 1 FROM "Funds"),
    'NEW FUND NAME',
    'με έδρα το Δουβλίνο Ιρλανδίας',
    'MAEDAP NAME',
    'MAEDAP Address'
);

-- Add a new zone
INSERT INTO "Zones" ("Id", "Name", "Value", "Tax", "TaxedValue")
VALUES (
    (SELECT COALESCE(MAX("Id"), 0) + 1 FROM "Zones"),
    'Ε',
    120.00,
    28.80,
    148.80
);

-- Add a new bank
INSERT INTO "Banks" ("Id", "Name", "DiakritikosTitlos", "Edra", "AFM")
VALUES (
    (SELECT COALESCE(MAX("Id"), 0) + 1 FROM "Banks"),
    'ΤΡΑΠΕΖΑ ΟΝΟΜΑ',
    'Διακριτικός Τίτλος',
    'Έδρα της τράπεζας',
    '123456789'
);

-- ============================================
-- UPDATE DATA
-- ============================================

-- Update a bailiff
UPDATE "Baillifs"
SET "Name" = 'Updated Name',
    "City" = 'Updated City',
    "AFM" = 'Updated AFM'
WHERE "Id" = 1;

-- Update an attorney
UPDATE "Attorneys"
SET "Name" = 'Updated Name',
    "City" = 'Updated City',
    "Pronoun" = 'του',
    "Description" = 'Updated Description',
    "GiaSunexisi" = 'Updated GiaSunexisi'
WHERE "Id" = 200;

-- Update a fund
UPDATE "Funds"
SET "Name" = 'Updated Fund Name',
    "Description" = 'Updated Description'
WHERE "Id" = 1;

-- Update zone pricing
UPDATE "Zones"
SET "Value" = 40.00,
    "Tax" = 9.60,
    "TaxedValue" = 49.60
WHERE "Name" = 'Α';

-- ============================================
-- DELETE DATA
-- ============================================

-- Delete a bailiff
DELETE FROM "Baillifs" WHERE "Id" = 999;

-- Delete an attorney
DELETE FROM "Attorneys" WHERE "Id" = 999;

-- Delete a fund
DELETE FROM "Funds" WHERE "Id" = 999;

-- Delete a zone
DELETE FROM "Zones" WHERE "Id" = 999;

-- ============================================
-- STATISTICS & REPORTS
-- ============================================

-- Count records in each table
SELECT 'Baillifs' as "Table", COUNT(*) as "Count" FROM "Baillifs"
UNION ALL
SELECT 'Attorneys', COUNT(*) FROM "Attorneys"
UNION ALL
SELECT 'Funds', COUNT(*) FROM "Funds"
UNION ALL
SELECT 'Zones', COUNT(*) FROM "Zones"
UNION ALL
SELECT 'EkthesiEpidoshsModels', COUNT(*) FROM "EkthesiEpidoshsModels"
UNION ALL
SELECT 'DebtorsForSunexisi', COUNT(*) FROM "DebtorsForSunexisi"
UNION ALL
SELECT 'Banks', COUNT(*) FROM "Banks";

-- Count attorneys by type
SELECT 
    CASE 
        WHEN "Id" < 100 THEN 'Notaries'
        WHEN "Id" BETWEEN 100 AND 199 THEN 'Notaries (New)'
        ELSE 'Attorneys'
    END as "Type",
    COUNT(*) as "Count"
FROM "Attorneys"
GROUP BY 
    CASE 
        WHEN "Id" < 100 THEN 'Notaries'
        WHEN "Id" BETWEEN 100 AND 199 THEN 'Notaries (New)'
        ELSE 'Attorneys'
    END
ORDER BY "Count" DESC;

-- List attorneys by city
SELECT "City", COUNT(*) as "Count"
FROM "Attorneys"
GROUP BY "City"
ORDER BY "Count" DESC;

-- ============================================
-- SEARCH QUERIES
-- ============================================

-- Search attorneys by name (case-insensitive)
SELECT * FROM "Attorneys" 
WHERE LOWER("Name") LIKE LOWER('%search_term%')
ORDER BY "Id";

-- Search funds by name
SELECT * FROM "Funds" 
WHERE LOWER("Name") LIKE LOWER('%galaxy%')
ORDER BY "Id";

-- Find all attorneys in a specific city
SELECT * FROM "Attorneys" 
WHERE "City" = 'Αθηνών'
ORDER BY "Name";

-- ============================================
-- BACKUP & RESTORE
-- ============================================

-- To backup from command line:
-- pg_dump -U postgres -d WordManipulationDb -F c -f backup.dump

-- To restore from command line:
-- pg_restore -U postgres -d WordManipulationDb -c backup.dump

-- ============================================
-- RESET DATABASE (USE WITH CAUTION!)
-- ============================================

-- Drop all tables (will lose all data!)
-- DROP TABLE IF EXISTS "__EFMigrationsHistory" CASCADE;
-- DROP TABLE IF EXISTS "Baillifs" CASCADE;
-- DROP TABLE IF EXISTS "Attorneys" CASCADE;
-- DROP TABLE IF EXISTS "Funds" CASCADE;
-- DROP TABLE IF EXISTS "Zones" CASCADE;
-- DROP TABLE IF EXISTS "EkthesiEpidoshsModels" CASCADE;
-- DROP TABLE IF EXISTS "DebtorsForSunexisi" CASCADE;
-- DROP TABLE IF EXISTS "Banks" CASCADE;

-- After dropping tables, run in your application:
-- dotnet ef database update

-- ============================================
-- USEFUL ADMIN QUERIES
-- ============================================

-- Check database size
SELECT pg_size_pretty(pg_database_size('WordManipulationDb'));

-- List all tables
SELECT tablename FROM pg_tables 
WHERE schemaname = 'public' 
ORDER BY tablename;

-- Show table sizes
SELECT 
    tablename,
    pg_size_pretty(pg_total_relation_size(schemaname||'.'||tablename)) AS size
FROM pg_tables
WHERE schemaname = 'public'
ORDER BY pg_total_relation_size(schemaname||'.'||tablename) DESC;

-- Check for missing indexes
SELECT 
    schemaname,
    tablename,
    attname
FROM pg_stats
WHERE schemaname = 'public'
  AND n_distinct > 100
  AND null_frac < 0.1
ORDER BY tablename, attname;
