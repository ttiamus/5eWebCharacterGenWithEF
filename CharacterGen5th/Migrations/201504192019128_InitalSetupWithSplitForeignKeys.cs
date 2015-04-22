namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalSetupWithSplitForeignKeys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbilityScores",
                c => new
                    {
                        AbilityScore_Id = c.Int(nullable: false, identity: true),
                        Ability = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AbilityScore_Id);
            
            CreateTable(
                "dbo.Alignments",
                c => new
                    {
                        Alignment_Id = c.Int(nullable: false, identity: true),
                        Alignment_Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Alignment_Id);
            
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
                    })
                .PrimaryKey(t => t.Armor_Id);
            
            CreateTable(
                "dbo.Backgrounds",
                c => new
                    {
                        Background_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Background_Id);
            
            CreateTable(
                "dbo.BackgroundToItems",
                c => new
                    {
                        BackgroundToItem_Id = c.Int(nullable: false, identity: true),
                        Background_Id = c.Int(nullable: false),
                        Item_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BackgroundToItem_Id)
                .ForeignKey("dbo.Backgrounds", t => t.Background_Id, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.Item_Id, cascadeDelete: true)
                .Index(t => t.Background_Id)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Item_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ItemType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Item_Id);
            
            CreateTable(
                "dbo.BackgroundToLanguages",
                c => new
                    {
                        BackgroundToLanguage_Id = c.Int(nullable: false, identity: true),
                        Background_Id = c.Int(nullable: false),
                        Language_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BackgroundToLanguage_Id)
                .ForeignKey("dbo.Backgrounds", t => t.Background_Id, cascadeDelete: true)
                .ForeignKey("dbo.Languages", t => t.Language_Id, cascadeDelete: true)
                .Index(t => t.Background_Id)
                .Index(t => t.Language_Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Language_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Language_Id);
            
            CreateTable(
                "dbo.BackgroundToSkillMaping",
                c => new
                    {
                        BackgroundToSkill_Id = c.Int(nullable: false, identity: true),
                        Background_Id = c.Int(nullable: false),
                        Skill_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BackgroundToSkill_Id)
                .ForeignKey("dbo.Backgrounds", t => t.Background_Id, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.Skill_Id, cascadeDelete: true)
                .Index(t => t.Background_Id)
                .Index(t => t.Skill_Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Skill_Id = c.Int(nullable: false, identity: true),
                        SkillName = c.String(nullable: false),
                        AbilityScore_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Skill_Id)
                .ForeignKey("dbo.AbilityScores", t => t.AbilityScore_Id, cascadeDelete: true)
                .Index(t => t.AbilityScore_Id);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Class_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        HitDie = c.Int(nullable: false),
                        PrimaryAbility = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Class_Id);
            
            CreateTable(
                "dbo.ClassToArmor",
                c => new
                    {
                        ClassToArmor_Id = c.Int(nullable: false, identity: true),
                        Class_Id = c.Int(nullable: false),
                        Armor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassToArmor_Id)
                .ForeignKey("dbo.Armors", t => t.Armor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Class_Id, cascadeDelete: true)
                .Index(t => t.Class_Id)
                .Index(t => t.Armor_Id);
            
            CreateTable(
                "dbo.ClassToSpells",
                c => new
                    {
                        ClassToSpell_Id = c.Int(nullable: false, identity: true),
                        Class_Id = c.Int(nullable: false),
                        Spell_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassToSpell_Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id, cascadeDelete: true)
                .ForeignKey("dbo.Spells", t => t.Spell_Id, cascadeDelete: true)
                .Index(t => t.Class_Id)
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
                "dbo.ClassToWeapon",
                c => new
                    {
                        ClassToWeapon_Id = c.Int(nullable: false, identity: true),
                        Class_Id = c.Int(nullable: false),
                        Weapon_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassToWeapon_Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id, cascadeDelete: true)
                .ForeignKey("dbo.Weapons", t => t.Weapon_Id, cascadeDelete: true)
                .Index(t => t.Class_Id)
                .Index(t => t.Weapon_Id);
            
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
                    })
                .PrimaryKey(t => t.Weapon_Id);
            
            CreateTable(
                "dbo.Feats",
                c => new
                    {
                        Feat_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Benefits = c.String(),
                    })
                .PrimaryKey(t => t.Feat_Id);
            
            CreateTable(
                "dbo.RaceProperties",
                c => new
                    {
                        RaceProperty_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.RaceProperty_Id);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        Race_Id = c.Int(nullable: false, identity: true),
                        RaceName = c.String(nullable: false),
                        Size_Id = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        SubRace_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Race_Id)
                .ForeignKey("dbo.Sizes", t => t.Size_Id, cascadeDelete: true)
                .ForeignKey("dbo.Races", t => t.SubRace_Id)
                .Index(t => t.Size_Id)
                .Index(t => t.SubRace_Id);
            
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
                "dbo.RaceToAbilityScores",
                c => new
                    {
                        RaceToAbilityScore_Id = c.Int(nullable: false, identity: true),
                        Race_Id = c.Int(nullable: false),
                        AbilityScore_1 = c.Int(nullable: false),
                        AbilityScore_1_Bonus = c.Int(nullable: false),
                        AbilityScore_2 = c.Int(),
                        AbilityScore_2_Bonus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RaceToAbilityScore_Id)
                .ForeignKey("dbo.AbilityScores", t => t.AbilityScore_1, cascadeDelete: true)
                .ForeignKey("dbo.AbilityScores", t => t.AbilityScore_2)
                .ForeignKey("dbo.Races", t => t.Race_Id, cascadeDelete: true)
                .Index(t => t.Race_Id)
                .Index(t => t.AbilityScore_1)
                .Index(t => t.AbilityScore_2);
            
            CreateTable(
                "dbo.RaceToLanguages",
                c => new
                    {
                        RaceToLanguage_Id = c.Int(nullable: false, identity: true),
                        Race_Id = c.Int(nullable: false),
                        Language_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RaceToLanguage_Id)
                .ForeignKey("dbo.Languages", t => t.Language_Id, cascadeDelete: true)
                .ForeignKey("dbo.Races", t => t.Race_Id, cascadeDelete: true)
                .Index(t => t.Race_Id)
                .Index(t => t.Language_Id);
            
            CreateTable(
                "dbo.RaceToRaceProperties",
                c => new
                    {
                        RaceToRaceProperty_Id = c.Int(nullable: false, identity: true),
                        Race_Id = c.Int(nullable: false),
                        RaceProperty_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RaceToRaceProperty_Id)
                .ForeignKey("dbo.Races", t => t.Race_Id, cascadeDelete: true)
                .ForeignKey("dbo.RaceProperties", t => t.RaceProperty_Id, cascadeDelete: true)
                .Index(t => t.Race_Id)
                .Index(t => t.RaceProperty_Id);
            
            CreateTable(
                "dbo.WeaponProperties",
                c => new
                    {
                        WeaponProperty_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.WeaponProperty_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RaceToRaceProperties", "RaceProperty_Id", "dbo.RaceProperties");
            DropForeignKey("dbo.RaceToRaceProperties", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.RaceToLanguages", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.RaceToLanguages", "Language_Id", "dbo.Languages");
            DropForeignKey("dbo.RaceToAbilityScores", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.RaceToAbilityScores", "AbilityScore_2", "dbo.AbilityScores");
            DropForeignKey("dbo.RaceToAbilityScores", "AbilityScore_1", "dbo.AbilityScores");
            DropForeignKey("dbo.Races", "SubRace_Id", "dbo.Races");
            DropForeignKey("dbo.Races", "Size_Id", "dbo.Sizes");
            DropForeignKey("dbo.ClassToWeapon", "Weapon_Id", "dbo.Weapons");
            DropForeignKey("dbo.ClassToWeapon", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.ClassToSpells", "Spell_Id", "dbo.Spells");
            DropForeignKey("dbo.ClassToSpells", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.ClassToArmor", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.ClassToArmor", "Armor_Id", "dbo.Armors");
            DropForeignKey("dbo.BackgroundToSkillMaping", "Skill_Id", "dbo.Skills");
            DropForeignKey("dbo.Skills", "AbilityScore_Id", "dbo.AbilityScores");
            DropForeignKey("dbo.BackgroundToSkillMaping", "Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.BackgroundToLanguages", "Language_Id", "dbo.Languages");
            DropForeignKey("dbo.BackgroundToLanguages", "Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.BackgroundToItems", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.BackgroundToItems", "Background_Id", "dbo.Backgrounds");
            DropIndex("dbo.RaceToRaceProperties", new[] { "RaceProperty_Id" });
            DropIndex("dbo.RaceToRaceProperties", new[] { "Race_Id" });
            DropIndex("dbo.RaceToLanguages", new[] { "Language_Id" });
            DropIndex("dbo.RaceToLanguages", new[] { "Race_Id" });
            DropIndex("dbo.RaceToAbilityScores", new[] { "AbilityScore_2" });
            DropIndex("dbo.RaceToAbilityScores", new[] { "AbilityScore_1" });
            DropIndex("dbo.RaceToAbilityScores", new[] { "Race_Id" });
            DropIndex("dbo.Races", new[] { "SubRace_Id" });
            DropIndex("dbo.Races", new[] { "Size_Id" });
            DropIndex("dbo.ClassToWeapon", new[] { "Weapon_Id" });
            DropIndex("dbo.ClassToWeapon", new[] { "Class_Id" });
            DropIndex("dbo.ClassToSpells", new[] { "Spell_Id" });
            DropIndex("dbo.ClassToSpells", new[] { "Class_Id" });
            DropIndex("dbo.ClassToArmor", new[] { "Armor_Id" });
            DropIndex("dbo.ClassToArmor", new[] { "Class_Id" });
            DropIndex("dbo.Skills", new[] { "AbilityScore_Id" });
            DropIndex("dbo.BackgroundToSkillMaping", new[] { "Skill_Id" });
            DropIndex("dbo.BackgroundToSkillMaping", new[] { "Background_Id" });
            DropIndex("dbo.BackgroundToLanguages", new[] { "Language_Id" });
            DropIndex("dbo.BackgroundToLanguages", new[] { "Background_Id" });
            DropIndex("dbo.BackgroundToItems", new[] { "Item_Id" });
            DropIndex("dbo.BackgroundToItems", new[] { "Background_Id" });
            DropTable("dbo.WeaponProperties");
            DropTable("dbo.RaceToRaceProperties");
            DropTable("dbo.RaceToLanguages");
            DropTable("dbo.RaceToAbilityScores");
            DropTable("dbo.Sizes");
            DropTable("dbo.Races");
            DropTable("dbo.RaceProperties");
            DropTable("dbo.Feats");
            DropTable("dbo.Weapons");
            DropTable("dbo.ClassToWeapon");
            DropTable("dbo.Spells");
            DropTable("dbo.ClassToSpells");
            DropTable("dbo.ClassToArmor");
            DropTable("dbo.Classes");
            DropTable("dbo.Skills");
            DropTable("dbo.BackgroundToSkillMaping");
            DropTable("dbo.Languages");
            DropTable("dbo.BackgroundToLanguages");
            DropTable("dbo.Items");
            DropTable("dbo.BackgroundToItems");
            DropTable("dbo.Backgrounds");
            DropTable("dbo.Armors");
            DropTable("dbo.Alignments");
            DropTable("dbo.AbilityScores");
        }
    }
}
