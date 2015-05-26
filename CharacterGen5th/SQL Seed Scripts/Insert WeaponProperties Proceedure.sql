USE [CharacterGen]
GO
IF EXISTS (Select * from sys.procedures WHERE name = 'InsertWeaponProperties')
	Drop procedure InsertWeaponProperties
GO

Create Procedure InsertWeaponProperties
as
Begin
	Delete From WeaponProperties Where WeaponProperty_Id > -1;
	DBCC CHECKIDENT (WeaponProperties, RESEED, 0);
  --insert into WeaponProperties values ('Name, Description)

	insert into WeaponProperties values ('Finesse', 'When making an attack with a finesse weapon, you use your choice of Strength or Dexterity modifier for the attack and damage rolls. You must use the same modifier for both rolls.');
	insert into WeaponProperties values ('Heavy', 'Small creatures have disadvantage on attack rolls with heavy weapons');
	insert into WeaponProperties values ('Light', 'A light weapon is small and easy to handle, making it ideal for use when fighting with two weapons.');
	insert into WeaponProperties values ('Loading', 'You can only fire one piece of ammunition from it when you use an action to fire it, regardless of the number of attacks you can normally make.');
	insert into WeaponProperties values ('Reach', 'This weapon adds 5 feet to your reach when you attack with it');
	insert into WeaponProperties values ('Special Lance', 'You have disadvantage when you use a lance to attack a target within 5 feet of you. Also, a lance requires two hands to wield when you aren''t mounted.');
	insert into WeaponProperties values ('Special Net', 'A Large or smaller creature hit by a net is restrained until it is freed. A net has no effect on creatures that are formless, or creatures that are Huuge or larger. A creature can use its action to make a DC 10 Strength check, freeing itself or another creature within its reach on a success. Dealing 5 slashing damage to the net (AC 10) also frees the creature without harming it, ending the effect and destroying the net/ When you use an action to attack with a net, you can only make one attack regardless of the number of attacks you can normally make.');
	insert into WeaponProperties values ('Thrown', 'You can throw the weapon to make a ranged attack. If it is a melee weapon, use the same ability modifier for the attack and damage as you would use for a melee attack with that weapon.');
	insert into WeaponProperties values ('Two-Handed', 'This weapon requires two hands to use.');
	insert into WeaponProperties values ('Versatile', 'This weapon can be used with one or two hands. A damage value in parentheses appears when the weapon is used with two hands to make a melee attack. The damage increases by one dice size.');
end;