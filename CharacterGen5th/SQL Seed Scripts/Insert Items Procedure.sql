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

	insert into Items values ('Arrow', .05, .05, 'Ammunition');
	insert into Items values ('Blowgun Needle', .02, .02, 'Ammunition');
	insert into Items values ('Crossbow Bolt', .05, .075, 'Ammunition');
	insert into Items values ('Sling Bullet', .002, .075, 'Ammunition');

	insert into Items values ('Bit and Bridle', 2, 1, 'Animal Equipment');
	insert into Items values ('Carriage', 100, 600, 'Animal Equipment');
	insert into Items values ('Cart', 15, 200, 'Animal Equipment');
	insert into Items values ('Chariot', 250, 100, 'Animal Equipment');
	insert into Items values ('Feed (per day)', .05, 10, 'Animal Equipment');
	insert into Items values ('Saddle, Exotic', 60, 40, 'Animal Equipment');
	insert into Items values ('Saddle, Military', 20, 30, 'Animal Equipment');
	insert into Items values ('Saddle, Pack', 5, 15, 'Animal Equipment');
	insert into Items values ('Saddle, Riding', 10, 25, 'Animal Equipment');
	insert into Items values ('Saddlebags', 4, 8, 'Animal Equipment');
	insert into Items values ('Sled', 20, 300, 'Animal Equipment');
	insert into Items values ('Wagon', 35, 400, 'Animal Equipment');

	insert into Items values ('Crystal', 10, 1, 'Arcane Focus');
	insert into Items values ('Orb', 20, 3, 'Arcane Focus');
	insert into Items values ('Rod', 10, 2, 'Arcane Focus');
	insert into Items values ('Staff', 5, 4, 'Arcane Focus');
	insert into Items values ('Wand', 10, 1, 'Arcane Focus');

	insert into Items values ('Sprig of Mistletoe', 1, 0, 'Druidic Focus');
	insert into Items values ('Totem', 1, 0, 'Druidic Focus');
	insert into Items values ('Wooden Staff', 5, 4, 'Druidic Focus');
	insert into Items values ('Yew Wand', 10, 1, 'Druidic Focus');

	insert into Items values ('Amulet', 5, 1, 'Holy Symbol');
	insert into Items values ('Emblem', 5, 0, 'Holy Symbol');
	insert into Items values ('Reliquary', 5, 2, 'Holy Symbol');

	insert into Items values ('Dice Set', .1, 0, 'Game Set');
	insert into Items values ('Dragonchess Set', 1, .5, 'Game Set');
	insert into Items values ('Playing Card Set', .5, 0, 'Game Set');
	insert into Items values ('Three-Dragon Ante Set', 1, 0, 'Game Set');

	insert into Items values ('Abacus', 2, 2, 'General');
	insert into Items values ('Acid (vial)', 25, 1, 'General');
	insert into Items values ('Alchemist''s Fire (flask)', 50, 1, 'General');
	insert into Items values ('Antitoxin (vial)', 50, 0, 'General');
	insert into Items values ('Backpack', 2, 5, 'General');
	insert into Items values ('Ball Bearings (bag of 1000)', 1, 2, 'General');
	insert into Items values ('Barrel', 2, 70, 'General');
	insert into Items values ('Basket', .4, 2, 'General');
	insert into Items values ('Bedroll', 1, 7, 'General');
	insert into Items values ('Bell', 1, 0, 'General');
	insert into Items values ('Blanket', .5, 3, 'General');
	insert into Items values ('Block and Tackle', 1, 5, 'General');
	insert into Items values ('Book', 25, 5, 'General');
	insert into Items values ('Bottle, Glass', 2, 2, 'General');
	insert into Items values ('Bucket', .05, 2, 'General');
	insert into Items values ('Caltrops (bag of 20)', 1, 2, 'General');
	insert into Items values ('Candle', .01, 0, 'General');
	insert into Items values ('Case, Crossbow Bolt', 1, 1, 'General');
	insert into Items values ('Case, Map or Scroll', 1, 1, 'General');
	insert into Items values ('Chain (10 feet)', 5, 10, 'General');
	insert into Items values ('Chalk (1 piece)', .01, 0, 'General');
	insert into Items values ('Chest', 5, 25, 'General');
	insert into Items values ('Climber''s Kit', 25, 12, 'General');
	insert into Items values ('Clothes, Common', .5, 3, 'General');
	insert into Items values ('Clothes, Costume', 5, 4, 'General');
	insert into Items values ('Clothes, Fine', 15, 6, 'General');
	insert into Items values ('Clothes, Traveler''s', 2, 4, 'General');
	insert into Items values ('Component Pouch', 25, 2, 'General');
	insert into Items values ('Crowbar', 2, 5, 'General');
	insert into Items values ('Fishing Tackle', 1, 4, 'General');
	insert into Items values ('Flask', .02, 1, 'General');
	insert into Items values ('Grappling Hook', 2, 4, 'General');
	insert into Items values ('Hammer', 1, 3, 'General');
	insert into Items values ('Hammer, Sledge', 2, 10, 'General');
	insert into Items values ('Healer''s Kit', 5, 3, 'General');
	insert into Items values ('Holy Water (flask)', 25, 1, 'General');
	insert into Items values ('Hourglass', 25, 1, 'General');
	insert into Items values ('Hunting Trap', 5, 25, 'General');
	insert into Items values ('Ink (1 ounce bottle)', 10, 0, 'General');
	insert into Items values ('Ink Pen', .02, 0, 'General');
	insert into Items values ('Jug', .02, 4, 'General');
	insert into Items values ('Ladder (10-foot)', .1, 25, 'General');
	insert into Items values ('Lamp', .5, 1, 'General');
	insert into Items values ('Lantern, Bullseye', 10, 2, 'General');
	insert into Items values ('Lantern, Hooded', 5, 2, 'General');
	insert into Items values ('Lock', 10, 1, 'General');
	insert into Items values ('Magnifying Glass', 100, 0, 'General');
	insert into Items values ('Manacles', 2, 6, 'General');
	insert into Items values ('Mess Kit', .2, 1, 'General');
	insert into Items values ('Mirror, Steel', 5, .5, 'General');
	insert into Items values ('Oil, (flask)', .1, 1, 'General');
	insert into Items values ('Paper (1 sheet)', .2, 0, 'General');
	insert into Items values ('Parchment (1 sheet)', .1, 0, 'General');
	insert into Items values ('Perfume (vial)', 5, 0, 'General');
	insert into Items values ('Pick, Miner''s', 2, 10, 'General');
	insert into Items values ('Pitcher', .02, 4, 'General');
	insert into Items values ('Piton', .05, .25, 'General');
	insert into Items values ('Poison, Basic (vial)', 100, 0, 'General');
	insert into Items values ('Pole (10-foot)', .05, 7, 'General');
	insert into Items values ('Pot, Iron', 2, 10, 'General');
	insert into Items values ('Potion of Healing', 50, .5, 'General');
	insert into Items values ('Pouch', .5, 1, 'General');
	insert into Items values ('Quiver', 1, 1, 'General');
	insert into Items values ('Ram, Portable', 4, 35, 'General');
	insert into Items values ('Rations (1 day)', .5, 2, 'General');
	insert into Items values ('Robes', 1, 4, 'General');
	insert into Items values ('Rope, Hempen (50 feet)', 1, 10, 'General');
	insert into Items values ('Rope, Silk (50 feet)', 10, 5, 'General');
	insert into Items values ('Sack', .01, .5, 'General');
	insert into Items values ('Scale, Merchant''s', 5, 3, 'General');
	insert into Items values ('Sealing Wax', .5, 0, 'General');
	insert into Items values ('Shovel', 2, 5, 'General');
	insert into Items values ('Signal Whistle', .05, 0, 'General');
	insert into Items values ('Signet Ring', 5, 0, 'General');
	insert into Items values ('Soap', .02, 0, 'General');
	insert into Items values ('Spellbook', 50, 3, 'General');
	insert into Items values ('Spikes, Iron', .1, .5, 'General');
	insert into Items values ('Spyglass', 1000, 1, 'General');
	insert into Items values ('Tankard', .02, 1, 'General');
	insert into Items values ('Tent, Two-Person', 2, 20, 'General');
	insert into Items values ('Tinderbox', .5, 1, 'General');
	insert into Items values ('Torch', .01, 1, 'General');
	insert into Items values ('Vial', 1, 0, 'General');
	insert into Items values ('Waterskin', .2, 5, 'General');
	insert into Items values ('Whetstone', .01, 1, 'General');

	insert into Items values ('Bagpipes', 30, 6, 'Musical Instrument');
	insert into Items values ('Drum', 6, 3, 'Musical Instrument');
	insert into Items values ('Dulcimer', 25, 10, 'Musical Instrument');
	insert into Items values ('Flute', 2, 1, 'Musical Instrument');
	insert into Items values ('Lute', 35, 2, 'Musical Instrument');
	insert into Items values ('Lyre', 30, 2, 'Musical Instrument');
	insert into Items values ('Horn', 3, 2, 'Musical Instrument');
	insert into Items values ('Pan Flute', 12, 2, 'Musical Instrument');
	insert into Items values ('Shawm', 2, 1, 'Musical Instrument');
	insert into Items values ('Viol', 30, 1, 'Musical Instrument');

	insert into Items values ('Alchemist''s Supplies', 50, 8, 'Tool');
	insert into Items values ('Brewer''s Supplies', 20, 9, 'Tool');
	insert into Items values ('Calligrapher''s Supplies', 10, 5, 'Tool');
	insert into Items values ('Carpenter''s Tools', 8, 6, 'Tool');
	insert into Items values ('Cartographer''s Tools', 15, 6, 'Tool');
	insert into Items values ('Cobbler''s Tools', 5, 5, 'Tool');
	insert into Items values ('Cook''s Utensils', 1, 8, 'Tool');
	insert into Items values ('Glassblower''s Tools', 30, 5, 'Tool');
	insert into Items values ('Jeweler''s Tools', 25, 2, 'Tool');
	insert into Items values ('Leatherworker''s Tools', 5, 5, 'Tool');
	insert into Items values ('Mason''s Tools', 10, 8, 'Tool');
	insert into Items values ('Painter''s Supplies', 10, 5, 'Tool');
	insert into Items values ('Potter''s Tools', 10, 3, 'Tool');
	insert into Items values ('Smith''s Tools', 20, 8, 'Tool');
	insert into Items values ('Tiniker''s Tools', 50, 10, 'Tool');
	insert into Items values ('Weaver''s Tools', 1, 5, 'Tool');
	insert into Items values ('Woodcarver''s Tools', 1, 5, 'Tool');
	insert into Items values ('Disguise Kit', 25, 3, 'Tool');
	insert into Items values ('Forgery Kit', 15, 5, 'Tool');
	insert into Items values ('Herbalism Kit', 5, 3, 'Tool');
	insert into Items values ('Navigator''s Tools', 25, 2, 'Tool');
	insert into Items values ('Poisoner''s Kit', 50, 2, 'Tool');
	insert into Items values ('Thieves'' Tools', 25, 2, 'Tool');
end;