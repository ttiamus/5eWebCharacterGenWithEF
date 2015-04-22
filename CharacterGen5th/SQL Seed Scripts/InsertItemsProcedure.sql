USE [CharGen5thCodeFirst]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertItems')
	Drop procedure InsertItems
GO

Create Procedure InsertItems
as
Begin
	Delete From Items Where Item_Id > -1;
	DBCC CHECKIDENT (Items, RESEED, 0);
  --insert into Items values ('Name, Cost, Weight, Type)
	
	insert into Items values ('', 0, 0, '');

end;