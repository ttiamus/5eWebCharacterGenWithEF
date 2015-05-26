USE [CharacterGen]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertAlignments')
	Drop procedure InsertAlignments
GO

Create Procedure InsertAlignments
as
Begin
	Delete From Alignments Where Alignment_Id > -1;
	DBCC CHECKIDENT (Alignments, RESEED, 0);
	insert into Alignments values ('Lawful Good');
	insert into Alignments values ('Neutral Good');
	insert into Alignments values ('Chaotic Good');
	insert into Alignments values ('Lawful Neutral');
	insert into Alignments values ('True Neutral');
	insert into Alignments values ('Chaotic Neutral');
	insert into Alignments values ('Lawful Evil');
	insert into Alignments values ('Neutral Evil');
	insert into Alignments values ('Chaotic Evil');
end;
