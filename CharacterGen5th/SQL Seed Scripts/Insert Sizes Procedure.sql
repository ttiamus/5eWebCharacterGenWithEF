USE [CharacterGen]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertSizes')
	Drop procedure InsertSizes
GO

Create Procedure InsertSizes
as
Begin
	Delete From Sizes Where Size_Id > -1;
	DBCC CHECKIDENT (Sizes, RESEED, 0);
  --insert into Size values (Name, AcIncrease, AcMod);

	insert into Sizes values ('Small', 0 , 0);
	insert into Sizes values ('Medium', 0, 0);
end;