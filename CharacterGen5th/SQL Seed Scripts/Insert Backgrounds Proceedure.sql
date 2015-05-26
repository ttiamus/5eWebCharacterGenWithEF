USE [CharacterGen]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertBackgrounds')
	Drop procedure InsertBackgrounds
GO

Create Procedure InsertBackgrounds
as
Begin
	Delete From Backgrounds Where Background_Id > -1;
	DBCC CHECKIDENT (Backgrounds, RESEED, 0);
  --insert into Backgrounds values (Name);

	insert into Backgrounds values ('Acolyte');
	insert into Backgrounds values ('Charlatan');
	insert into Backgrounds values ('Criminal');
	insert into Backgrounds values ('Entertainer');
	insert into Backgrounds values ('Guild Artisan');
	insert into Backgrounds values ('Hermit');
	insert into Backgrounds values ('Outlander');
	insert into Backgrounds values ('Sage');
	insert into Backgrounds values ('Sailor');
	insert into Backgrounds values ('Soldier');
	insert into Backgrounds values ('Urchin');
end;