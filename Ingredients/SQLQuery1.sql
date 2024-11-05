EXEC sp_rename 'Test.UnitType', 'Created by', 'COLUMN';
EXEC sp_rename 'Test.Created by', 'CreateBy', 'COLUMN';
EXEC sp_rename 'Test.Category', 'Category', 'COLUMN';

ALTER TABLE Test
ADD Price float;

ALTER TABLE Test
ADD isAvailable BIT DEFAULT 1;

ALTER TABLE Test
DROP COLUMN Created;

ALTER TABLE Test
ADD [Category] NCHAR(50);

ALTER TABLE Test
ADD Created DATETIME;

SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Test';