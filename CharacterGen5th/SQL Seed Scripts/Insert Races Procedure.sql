USE [CharacterGen]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertRaces')
	Drop procedure InsertRaces
GO

Create Procedure InsertRaces
as
Begin
	Delete From Races Where Race_Id > -1;
	DBCC CHECKIDENT (Races, RESEED, 0);
  --insert into Races values (Race, SizeId, Speed, SubraceOfRaceId);

	insert into Races values ('Dwarf', 2, 25);
	insert into Races values ('Elf', 2, 30);
	insert into Races values ('Dragonborn', 2, 30);
	insert into Races values ('Halfling', 1, 25);
	insert into Races values ('Human', 2, 30);
	insert into Races values ('Gnome', 1, 25);
	insert into Races values ('Half-Elf', 2, 30);
	insert into Races values ('Half-Orc', 2, 30);
	insert into Races values ('Tiefling', 2, 30);
	
	insert into Races values ('Dwarf, Hill', 2, 25);
	insert into Races values ('Dwarf, Mountain', 2, 25);
	insert into Races values ('Elf, Dark', 2, 30);
	insert into Races values ('Elf, High', 2, 30);
	insert into Races values ('Elf, Wood', 2, 30);
	insert into Races values ('Dragonborn, Black', 2, 30);
	insert into Races values ('Dragonborn, Blue', 2, 30);
	insert into Races values ('Dragonborn, Brass', 2, 30);
	insert into Races values ('Dragonborn, Bronze', 2, 30);
	insert into Races values ('Dragonborn, Copper', 2, 30);
	insert into Races values ('Dragonborn, Gold', 2, 30);
	insert into Races values ('Dragonborn, Green', 2, 30);
	insert into Races values ('Dragonborn, Red', 2, 30);
	insert into Races values ('Dragonborn, Silver', 2, 30);
	insert into Races values ('Dragonborn, White', 2, 30);
	insert into Races values ('Halfling, Lightfoot', 1, 25);
	insert into Races values ('Halfling, Stout', 1, 25);
	insert into Races values ('Human, Variant', 2, 30);
	insert into Races values ('Gnome, Forest', 1, 25);
	insert into Races values ('Gnome, Rock', 1, 25);	
end;




