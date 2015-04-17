namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbilityScores",
                c => new
                    {
                        AbilityScore_Id = c.Int(nullable: false, identity: true),
                        Ability = c.String(nullable: false),
                        Race_Id = c.Int(nullable: false),
                        Skill_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AbilityScore_Id)
                .ForeignKey("dbo.Races", t => t.Race_Id, cascadeDelete: true)
                .Index(t => t.Race_Id);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        Race_Id = c.Int(nullable: false, identity: true),
                        RaceName = c.String(nullable: false),
                        Size_Id = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Race_Id)
                .ForeignKey("dbo.Sizes", t => t.Size_Id, cascadeDelete: true)
                .Index(t => t.Size_Id);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        Size_Id = c.Int(nullable: false, identity: true),
                        SizeName = c.String(nullable: false),
                        AcIncrease = c.Boolean(nullable: false),
                        AcMod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Size_Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Skill_Id = c.Int(nullable: false),
                        SkillName = c.String(nullable: false),
                        AbilityScore_Id = c.Int(nullable: false),
                        Background_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Skill_Id)
                .ForeignKey("dbo.AbilityScores", t => t.Skill_Id)
                .ForeignKey("dbo.Backgrounds", t => t.Background_Id, cascadeDelete: true)
                .Index(t => t.Skill_Id)
                .Index(t => t.Background_Id);
            
            CreateTable(
                "dbo.Backgrounds",
                c => new
                    {
                        Background_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Background_Id);
            
            CreateTable(
                "dbo.Armors",
                c => new
                    {
                        Armor_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArmorType = c.String(nullable: false),
                        BaseAc = c.Int(nullable: false),
                        MaxDexMod = c.Int(nullable: false),
                        RequiredStr = c.Int(nullable: false),
                        StealthDisadvantage = c.Boolean(nullable: false),
                        Class_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Armor_Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id, cascadeDelete: true)
                .Index(t => t.Class_Id);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Class_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        HitDie = c.Int(nullable: false),
                        PrimaryAbility = c.String(nullable: false),
                        Spell_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Class_Id)
                .ForeignKey("dbo.Spells", t => t.Spell_Id, cascadeDelete: true)
                .Index(t => t.Spell_Id);
            
            CreateTable(
                "dbo.Spells",
                c => new
                    {
                        Spell_Id = c.Int(nullable: false, identity: true),
                        SpellName = c.String(nullable: false),
                        SpellDc = c.Int(nullable: false),
                        CastTime = c.String(nullable: false),
                        Duration = c.String(nullable: false),
                        Components = c.String(),
                        Range = c.String(nullable: false),
                        Target = c.String(nullable: false),
                        AreaOfEffect = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Spell_Id);
            
            CreateTable(
                "dbo.Feats",
                c => new
                    {
                        Feat_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Feat_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Item_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ItemType = c.String(nullable: false),
                        Background_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Item_Id)
                .ForeignKey("dbo.Backgrounds", t => t.Background_Id, cascadeDelete: true)
                .Index(t => t.Background_Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Language_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Race_Id = c.Int(nullable: false),
                        Background_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Language_Id)
                .ForeignKey("dbo.Backgrounds", t => t.Background_Id, cascadeDelete: true)
                .ForeignKey("dbo.Languages", t => t.Race_Id)
                .Index(t => t.Race_Id)
                .Index(t => t.Background_Id);
            
            CreateTable(
                "dbo.WeaponProperties",
                c => new
                    {
                        WeaponProperty_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.WeaponProperty_Id);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        Weapon_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WeaponType = c.String(nullable: false),
                        Damage = c.String(nullable: false),
                        DamageType = c.String(nullable: false),
                        MeleeWeapon = c.Boolean(nullable: false),
                        Range = c.Int(nullable: false),
                        RangeIncrement = c.Int(nullable: false),
                        ProficiencyNeeded = c.String(nullable: false),
                        Class_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Weapon_Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id, cascadeDelete: true)
                .Index(t => t.Class_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Weapons", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.Languages", "Race_Id", "dbo.Languages");
            DropForeignKey("dbo.Languages", "Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.Items", "Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.Armors", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.Classes", "Spell_Id", "dbo.Spells");
            DropForeignKey("dbo.Skills", "Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.Skills", "Skill_Id", "dbo.AbilityScores");
            DropForeignKey("dbo.AbilityScores", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Races", "Size_Id", "dbo.Sizes");
            DropIndex("dbo.Weapons", new[] { "Class_Id" });
            DropIndex("dbo.Languages", new[] { "Background_Id" });
            DropIndex("dbo.Languages", new[] { "Race_Id" });
            DropIndex("dbo.Items", new[] { "Background_Id" });
            DropIndex("dbo.Classes", new[] { "Spell_Id" });
            DropIndex("dbo.Armors", new[] { "Class_Id" });
            DropIndex("dbo.Skills", new[] { "Background_Id" });
            DropIndex("dbo.Skills", new[] { "Skill_Id" });
            DropIndex("dbo.Races", new[] { "Size_Id" });
            DropIndex("dbo.AbilityScores", new[] { "Race_Id" });
            DropTable("dbo.Weapons");
            DropTable("dbo.WeaponProperties");
            DropTable("dbo.Languages");
            DropTable("dbo.Items");
            DropTable("dbo.Feats");
            DropTable("dbo.Spells");
            DropTable("dbo.Classes");
            DropTable("dbo.Armors");
            DropTable("dbo.Backgrounds");
            DropTable("dbo.Skills");
            DropTable("dbo.Sizes");
            DropTable("dbo.Races");
            DropTable("dbo.AbilityScores");
        }
    }
}
