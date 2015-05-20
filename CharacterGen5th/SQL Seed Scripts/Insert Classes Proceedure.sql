USE [CharGen5thCodeFirst]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertClasses')
	Drop procedure InsertClasses
GO

Create Procedure InsertClasses
as
Begin
	Delete From Classes Where Class_Id > -1;
	DBCC CHECKIDENT (AbilityScores, RESEED, 0);
	insert into Classes values ('Barbarian', 12);
	insert into Classes values ('Bard', 8);
	insert into Classes values ('Cleric', 8);
	insert into Classes values ('Druid', 8);
	insert into Classes values ('Fighter', 10);
	insert into Classes values ('Monk', 8);
	insert into Classes values ('Paladin', 10);
	insert into Classes values ('Ranger', 10);
	insert into Classes values ('Rogue', 8);
	insert into Classes values ('Sorcerer', 6);
	insert into Classes values ('Warlock', 8);
	insert into Classes values ('Wizard', 6);
end;
