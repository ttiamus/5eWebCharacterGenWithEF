USE [CharacterGen]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertAbilityScores')
	Drop procedure InsertAbilityScores
GO

Create Procedure InsertAbilityScores
as
Begin
	Delete From AbilityScores Where AbilityScore_Id > -1;
	DBCC CHECKIDENT (AbilityScores, RESEED, 0);
	insert into AbilityScores values ('Str');
	insert into AbilityScores values ('Dex');
	insert into AbilityScores values ('Con');
	insert into AbilityScores values ('Int');
	insert into AbilityScores values ('Wis');
	insert into AbilityScores values ('Cha');
end;
