USE [CharacterGen]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertArmors')
	Drop procedure InsertArmors
GO

Create Procedure InsertArmors
as
Begin
	Delete From Armors Where Armor_Id > -1;
	DBCC CHECKIDENT (Armors, RESEED, 0);
  --insert into Armors values ('Name, Cost, Weight, Type, AC, Dex, ReqStr, SealthPen)

	insert into Armors values ('Padded', 5, 8, 'Light', 11, null, 0, 1);
	insert into Armors values ('Leather', 10, 10, 'Light', 11, null, 0, 0);
	insert into Armors values ('Studded Leather', 45, 13, 'Light', 12, null, 0, 0);

	insert into Armors values ('Hide', 10, 12, 'Medium', 12, 2, 0, 1);
	insert into Armors values ('Chain Shirt', 50, 20, 'Medium', 13, 2, 0, 1);
	insert into Armors values ('Scale Mail', 50, 45, 'Medium', 14, 2, 0, 1);
	insert into Armors values ('Breastplate', 400, 20, 'Medium', 14, 2, 0, 1);
	insert into Armors values ('Half Plate', 750, 40, 'Medium', 15, 2, 0, 1);

	insert into Armors values ('Ring Mail', 30, 40, 'Heavy', 14, 0, 0, 1);
	insert into Armors values ('Chain Mail', 75, 55, 'Heavy', 16, 0, 13, 1);
	insert into Armors values ('Splint', 200, 65, 'Heavy', 17, 0, 15, 1);
	insert into Armors values ('Plate', 1500, 65, 'Heavy', 18, 0, 15, 1);

	insert into Armors values ('Shield', 10, 2, 'Shield', 11, null, 0, 1);
end;