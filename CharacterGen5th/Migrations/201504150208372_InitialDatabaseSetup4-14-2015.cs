namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseSetup4142015 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbilityScoreModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ability = c.String(),
                        RaceModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RaceModels", t => t.RaceModel_Id)
                .Index(t => t.RaceModel_Id);
            
            CreateTable(
                "dbo.ArmorModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArmorType = c.String(),
                        BaseAc = c.Int(nullable: false),
                        MaxDexMod = c.Int(nullable: false),
                        RequiredStr = c.Int(nullable: false),
                        StealthDisadvantage = c.Boolean(nullable: false),
                        ClassModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassModels", t => t.ClassModel_Id)
                .Index(t => t.ClassModel_Id);
            
            CreateTable(
                "dbo.BackgroundModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ItemType = c.String(),
                        BackgroundModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BackgroundModels", t => t.BackgroundModel_Id)
                .Index(t => t.BackgroundModel_Id);
            
            CreateTable(
                "dbo.LanguageModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BackgroundModel_Id = c.Int(),
                        RaceModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BackgroundModels", t => t.BackgroundModel_Id)
                .ForeignKey("dbo.RaceModels", t => t.RaceModel_Id)
                .Index(t => t.BackgroundModel_Id)
                .Index(t => t.RaceModel_Id);
            
            CreateTable(
                "dbo.SkillModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SkillName = c.String(),
                        AbilityScore = c.String(),
                        BackgroundModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BackgroundModels", t => t.BackgroundModel_Id)
                .Index(t => t.BackgroundModel_Id);
            
            CreateTable(
                "dbo.ClassModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        HitDie = c.Int(nullable: false),
                        PrimaryAbility = c.String(),
                        SpellModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpellModels", t => t.SpellModel_Id)
                .Index(t => t.SpellModel_Id);
            
            CreateTable(
                "dbo.WeaponModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WeaponType = c.String(),
                        Damage = c.String(),
                        DamageType = c.String(),
                        MeleeWeapon = c.Boolean(nullable: false),
                        Range = c.Int(nullable: false),
                        RangeIncrement = c.Int(nullable: false),
                        ProficiencyNeeded = c.String(),
                        ClassModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassModels", t => t.ClassModel_Id)
                .Index(t => t.ClassModel_Id);
            
            CreateTable(
                "dbo.WeaponPropertyModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        WeaponModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WeaponModels", t => t.WeaponModel_Id)
                .Index(t => t.WeaponModel_Id);
            
            CreateTable(
                "dbo.FeatModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RaceModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RaceName = c.String(),
                        Speed = c.Int(nullable: false),
                        Size_Id = c.Int(),
                        RaceModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SizeModels", t => t.Size_Id)
                .ForeignKey("dbo.RaceModels", t => t.RaceModel_Id)
                .Index(t => t.Size_Id)
                .Index(t => t.RaceModel_Id);
            
            CreateTable(
                "dbo.SizeModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                        AcIncrease = c.Boolean(nullable: false),
                        AcMod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SpellModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SpellName = c.String(),
                        SpellDc = c.Int(nullable: false),
                        CastTime = c.String(),
                        Duration = c.String(),
                        Components = c.String(),
                        Range = c.String(),
                        Target = c.String(),
                        AreaOfEffect = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClassModels", "SpellModel_Id", "dbo.SpellModels");
            DropForeignKey("dbo.RaceModels", "RaceModel_Id", "dbo.RaceModels");
            DropForeignKey("dbo.RaceModels", "Size_Id", "dbo.SizeModels");
            DropForeignKey("dbo.AbilityScoreModels", "RaceModel_Id", "dbo.RaceModels");
            DropForeignKey("dbo.LanguageModels", "RaceModel_Id", "dbo.RaceModels");
            DropForeignKey("dbo.WeaponModels", "ClassModel_Id", "dbo.ClassModels");
            DropForeignKey("dbo.WeaponPropertyModels", "WeaponModel_Id", "dbo.WeaponModels");
            DropForeignKey("dbo.ArmorModels", "ClassModel_Id", "dbo.ClassModels");
            DropForeignKey("dbo.SkillModels", "BackgroundModel_Id", "dbo.BackgroundModels");
            DropForeignKey("dbo.LanguageModels", "BackgroundModel_Id", "dbo.BackgroundModels");
            DropForeignKey("dbo.ItemModels", "BackgroundModel_Id", "dbo.BackgroundModels");
            DropIndex("dbo.RaceModels", new[] { "RaceModel_Id" });
            DropIndex("dbo.RaceModels", new[] { "Size_Id" });
            DropIndex("dbo.WeaponPropertyModels", new[] { "WeaponModel_Id" });
            DropIndex("dbo.WeaponModels", new[] { "ClassModel_Id" });
            DropIndex("dbo.ClassModels", new[] { "SpellModel_Id" });
            DropIndex("dbo.SkillModels", new[] { "BackgroundModel_Id" });
            DropIndex("dbo.LanguageModels", new[] { "RaceModel_Id" });
            DropIndex("dbo.LanguageModels", new[] { "BackgroundModel_Id" });
            DropIndex("dbo.ItemModels", new[] { "BackgroundModel_Id" });
            DropIndex("dbo.ArmorModels", new[] { "ClassModel_Id" });
            DropIndex("dbo.AbilityScoreModels", new[] { "RaceModel_Id" });
            DropTable("dbo.SpellModels");
            DropTable("dbo.SizeModels");
            DropTable("dbo.RaceModels");
            DropTable("dbo.FeatModels");
            DropTable("dbo.WeaponPropertyModels");
            DropTable("dbo.WeaponModels");
            DropTable("dbo.ClassModels");
            DropTable("dbo.SkillModels");
            DropTable("dbo.LanguageModels");
            DropTable("dbo.ItemModels");
            DropTable("dbo.BackgroundModels");
            DropTable("dbo.ArmorModels");
            DropTable("dbo.AbilityScoreModels");
        }
    }
}
