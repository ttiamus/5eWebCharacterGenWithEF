USE [CharacterGen]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertRaceProperties')
	Drop procedure InsertRaceProperties
GO

Create Procedure InsertRaceProperties
as
Begin
	Delete From RaceProperties Where RaceProperty_Id > -1;
	DBCC CHECKIDENT (RaceProperties, RESEED, 0);
  --insert into RaceProperties values (Name, Description);

	insert into RaceProperties values ('Darkvision', 'Accustomed to life undergound, you have superior vision in dark and dim conditions. 
												      You can see in dim light within 60 feet of you as if it were bright light, and in 
													  darkness as if it were dim light. You can''t discern color in darkness, only shades of gray.');
	insert into RaceProperties values ('Dwarven Resilience', 'You have advantage on saving throws against poison, and you have resistance against poison damage');
	insert into RaceProperties values ('Dwarven Resilience', 'You have advantage on saving throws against poison, and you have resistance against poison damage');
	insert into RaceProperties values ('Dwarven Combat Training', 'You have proficiency with the battleaxe, handaxe, throwing hammer, and warhammer');
	insert into RaceProperties values ('Stonecunning', 'Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered 
														proficient in the History skill and add double your proficiency bonus to the check, instead of your normal profiency bonus.');

	insert into RaceProperties values ('Dwarven Toughness', 'You have advantage on saving throws against poison, and you have resistance against poison damage');
end;
