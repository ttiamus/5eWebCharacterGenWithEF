USE [CharacterGen]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertGods')
	Drop procedure InsertGods
GO

Create Procedure InsertGods
as
Begin
	Delete From Gods Where God_Id > -1;
	DBCC CHECKIDENT (Gods, RESEED, 0);
  --insert into Gods values (Name, Title, Alignment, Symbol);

  --Forgotten Realms
	insert into Gods values ('Auril', 'Goddess of Winter', 1, 'Six-pointed snowflake');
	insert into Gods values ('Azuth', 'God of Wizards', 1, 'Left hand pointing upward, outlined in fire');
	insert into Gods values ('Bane', 'God Tyranny', 1, 'Upright black right hand, thumb and fingers together');
	insert into Gods values ('Beshaba', 'Goddess of Misfortune', 1, 'Black antlers');
	insert into Gods values ('Bhaal', '', 1, '');
	insert into Gods values ('Chauntea', '', 1, '');
	insert into Gods values ('Cyric', '', 1, '');
	insert into Gods values ('Deneir', '', 1, '');
	insert into Gods values ('Eldath', '', 1, '');
	insert into Gods values ('Gond', '', 1, '');
	insert into Gods values ('Helm', '', 1, '');
	insert into Gods values ('Ilmater', '', 1, '');
	insert into Gods values ('Kelemvor', '', 1, '');
	insert into Gods values ('Lathander', '', 1, '');
	insert into Gods values ('Leira', '', 1, '');
	insert into Gods values ('Lliira', '', 1, '');
	insert into Gods values ('Loviatar', '', 1, '');
	insert into Gods values ('Malar', '', 1, '');
	insert into Gods values ('Mask', '', 1, '');
	insert into Gods values ('Mielikki', '', 1, '');
	insert into Gods values ('Milil', '', 1, '');
	insert into Gods values ('Myrkul', '', 1, '');
	insert into Gods values ('Mystra', '', 1, '');
	insert into Gods values ('Oghma', '', 1, '');
	insert into Gods values ('Savras', '', 1, '');
	insert into Gods values ('Selune', '', 1, '');
	insert into Gods values ('Shar', '', 1, '');
	insert into Gods values ('Silvanus', '', 1, '');
	insert into Gods values ('Sune', '', 1, '');
	insert into Gods values ('Talona', '', 1, '');
	insert into Gods values ('Talos', '', 1, '');
	insert into Gods values ('Tempus', '', 1, '');
	insert into Gods values ('Torm', '', 1, '');
	insert into Gods values ('Tymora', '', 1, '');
	insert into Gods values ('Tyr', '', 1, '');
	insert into Gods values ('Umberlee', '', 1, '');
	insert into Gods values ('Wauleem', '', 1, '');

  --Greyhawk
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');

  --Eberron
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');

  --Greyhawk
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');

  --Nonhuman
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
	insert into Gods values ('', '', 1, '');
end;




