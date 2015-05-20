USE [CharGen5thCodeFirst]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertWeapons')
	Drop procedure InsertWeapons
GO

Create Procedure InsertWeapons
as
Begin
	Delete From Weapons Where Weapon_Id > -1;
	DBCC CHECKIDENT (Weapons, RESEED, 0);
  --insert into Weapons values ('Name, Cost, Weight, WeaponType, Damage, DamageType, Melee?, Max Range, RangeInc)

	insert into Weapons values ('Club', .1, 2, 'Simple', '1d4', 'Bludgeoning', 1, null, null);
	insert into Weapons values ('Dagger', 2, 1, 'Simple', '1d4', 'Piercing', 1, null, null);
	insert into Weapons values ('Greatclub', .2, 10, 'Simple', '1d8', 'Bludgeoning', 1, null, null);
	insert into Weapons values ('Handaxe', 5, 2, 'Simple', '1d6', 'Slashing', 1, null, null);
	insert into Weapons values ('Javelin', .5, 2, 'Simple', '1d6', 'Piercing', 1, null, null);
	insert into Weapons values ('Light Hammer', 2, 2, 'Simple', '1d4', 'Bludgeoning', 1, null, null);
	insert into Weapons values ('Mace', 5, 4, 'Simple', '1d6', 'Bludgeoning', 1, null, null);
	insert into Weapons values ('Quarterstaff', .2, 4, 'Simple', '1d6', 'Bludgeoning', 1, null, null);
	insert into Weapons values ('Sickle', 1, 2, 'Simple', '1d4', 'Slashing', 1, null, null);
	insert into Weapons values ('Spear', 1, 3, 'Simple', '1d6', 'Piercing', 1, null, null);
	insert into Weapons values ('Unarmed Strike', 0, 0, 'Simple', '1', 'Bludgeoning', 1, null, null);
	
	insert into Weapons values ('Crossbow, Light', 25, 5, 'Simple', '1d8', 'Piercing', 0, 80, 320);
	insert into Weapons values ('Dart', .05, .25, 'Simple', '1d4', 'Piercing', 0, 20, 60);
	insert into Weapons values ('Shortbow', 25, 2, 'Simple', '1d6', 'Piercing', 0, 80, 320);
	insert into Weapons values ('Sling', .1, 0, 'Simple', '1d4', 'Bludgeoning', 0, 30, 120);

	insert into Weapons values ('Battleaxe', 10, 4, 'Martial', '1d8', 'Slashing', 1, null, null);
	insert into Weapons values ('Flail', 10, 2, 'Martial', '1d8', 'Bludgeoning', 1, null, null);
	insert into Weapons values ('Glaive', 20, 6, 'Martial', '1d10', 'Slashing', 1, null, null);
	insert into Weapons values ('Greataxe', 30, 7, 'Martial', '1d12', 'Slashing', 1, null, null);
	insert into Weapons values ('Greatsword', 50, 6, 'Martial', '2d6', 'Slashing', 1, null, null);
	insert into Weapons values ('Halberd', 20, 6, 'Martial', '1d10', 'Slashing', 1, null, null);
	insert into Weapons values ('Lance', 10, 6, 'Martial', '1d12', 'Piercing', 1, null, null);
	insert into Weapons values ('Longsword', 15, 3, 'Martial', '1d8', 'Slashing', 1, null, null);
	insert into Weapons values ('Maul', 10, 10, 'Martial', '2d6', 'Bludgeoning', 1, null, null);
	insert into Weapons values ('Morningstar', 15, 4, 'Martial', '1d8', 'Piercing', 1, null, null);
	insert into Weapons values ('Pike', 5, 18, 'Martial', '1d10', 'Piercing', 1, null, null);
	insert into Weapons values ('Rapier', 25, 2, 'Martial', '1d8', 'Piercing', 1, null, null);
	insert into Weapons values ('Scimitar', 25, 3, 'Martial', '1d6', 'Slashing', 1, null, null);
	insert into Weapons values ('Shortsword', 10, 2, 'Martial', '1d6', 'Piercing', 1, null, null);
	insert into Weapons values ('Trident', 5, 4, 'Martial', '1d6', 'Piercing', 1, null, null);
	insert into Weapons values ('War Pick', 5, 2, 'Martial', '1d8', 'Piercing', 1, null, null);
	insert into Weapons values ('Warhammer', 15, 2, 'Martial', '1d8', 'Bludgeoning', 1, null, null);
	insert into Weapons values ('Whip', 2, 3, 'Martial', '1d4', 'Slashing', 1, null, null);

	insert into Weapons values ('Blowgun', 10, 1, 'Martial', '1', 'Piercing', 0, 25, 100);
	insert into Weapons values ('Crossbow, Hand', 75, 3, 'Martial', '1d6', 'Piercing', 0, 30, 120);
	insert into Weapons values ('Crossbow, Heavy', 50, 18, 'Martial', '1d10', 'Piercing', 0, 100, 400);
	insert into Weapons values ('Longbow', 50, 2, 'Martial', '1d8', 'Piercing', 0, 150, 600);
	insert into Weapons values ('Net', 1, 3, 'Martial', '0', 'Piercinging', 0, 5, 15);
end;