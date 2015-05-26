USE [CharacterGen]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertSkills')
	Drop procedure InsertSkills
GO

Create Procedure InsertSkills
as
Begin
	Delete From Skills Where Skill_Id > -1;
	DBCC CHECKIDENT (Skills, RESEED, 0);
	insert into Skills values ('Athletics', '1');
	insert into Skills values ('Sleight of Hand', '2');
	insert into Skills values ('Sealth', '2');
	insert into Skills values ('Arcana', '4');
	insert into Skills values ('History', '4');
	insert into Skills values ('Investigation', '4');
	insert into Skills values ('Nature', '4');
	insert into Skills values ('Religion', '4');
	insert into Skills values ('Animal Handling', '5');
	insert into Skills values ('Insight', '5');
	insert into Skills values ('Medicine', '5');
	insert into Skills values ('Perception', '5');
	insert into Skills values ('Survival', '5');
	insert into Skills values ('Deception', '6');
	insert into Skills values ('Intimidation', '6');
	insert into Skills values ('Performance', '6');
	insert into Skills values ('Persuasion', '6');
end;