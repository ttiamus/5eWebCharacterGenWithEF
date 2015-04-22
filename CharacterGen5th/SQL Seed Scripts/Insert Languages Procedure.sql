USE [CharGen5thCodeFirst]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertLanguages')
	Drop procedure InsertLanguages
GO

Create Procedure InsertLanguages
as
Begin
	Delete From Languages Where Language_Id > -1;
	DBCC CHECKIDENT (Sizes, RESEED, 0);

	insert into Languages values ('Common');
	insert into Languages values ('Dwarvish');
	insert into Languages values ('Elvish');
	insert into Languages values ('Giant');
	insert into Languages values ('Gnomish');
	insert into Languages values ('Goblin');
	insert into Languages values ('Halfling');
	insert into Languages values ('Orc');

	insert into Languages values ('Abyssal');
	insert into Languages values ('Celestial');
	insert into Languages values ('Draconic');
	insert into Languages values ('Deep Speech');
	insert into Languages values ('Infernal');
	insert into Languages values ('Primordial');
	insert into Languages values ('Sylvan');
	insert into Languages values ('Undercommon');
end;