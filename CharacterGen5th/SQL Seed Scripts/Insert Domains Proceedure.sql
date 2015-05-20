USE [CharGen5thCodeFirst]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertDomains')
	Drop procedure InsertDomains
GO

Create Procedure InsertDomains
as
Begin
	Delete From [Domains] Where Domain_Id > -1;
	DBCC CHECKIDENT ([Domains], RESEED, 0);
  --insert into Gods values (Name);

	insert into [Domains] values ('Death');
	insert into [Domains] values ('Knowledge');
	insert into [Domains] values ('Life');
	insert into [Domains] values ('Light');
	insert into [Domains] values ('Nature');
	insert into [Domains] values ('Tempest');
	insert into [Domains] values ('Trickery');
	insert into [Domains] values ('War');
end;