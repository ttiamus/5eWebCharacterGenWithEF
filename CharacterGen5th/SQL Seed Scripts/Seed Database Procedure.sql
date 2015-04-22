use CharGen5thCodeFirst;

IF EXISTS (Select * from sys.procedures WHERE name = 'SeedDatabase')
	Drop procedure SeedDatabase
GO

Create Procedure SeedDatabase
as
BEGIN
	exec InsertAlignments
	exec InsertAbilityScores
	exec InsertSizes
	exec InsertLanguages
	exec InsertItems
	exec InsertRaces
	exec InsertRaceProperties
END;