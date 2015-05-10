namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Races", "SubRace_Id", "dbo.Races");
            DropIndex("dbo.Races", new[] { "SubRace_Id" });
            CreateTable(
                "dbo.ClassToAbilityScores",
                c => new
                    {
                        ClassToSaving_Id = c.Int(nullable: false, identity: true),
                        Class_Id = c.Int(nullable: false),
                        AbilityScore_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassToSaving_Id)
                .ForeignKey("dbo.AbilityScores", t => t.AbilityScore_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Class_Id, cascadeDelete: true)
                .Index(t => t.Class_Id)
                .Index(t => t.AbilityScore_Id);
            
            CreateTable(
                "dbo.ClassToSavingThrows",
                c => new
                    {
                        ClassToSaving_Id = c.Int(nullable: false, identity: true),
                        Class_Id = c.Int(nullable: false),
                        AbilityScore_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassToSaving_Id)
                .ForeignKey("dbo.AbilityScores", t => t.AbilityScore_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Class_Id, cascadeDelete: true)
                .Index(t => t.Class_Id)
                .Index(t => t.AbilityScore_Id);
            
            AddColumn("dbo.Classes", "SkillsPerLevel", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "BABProgression", c => c.String());
            AddColumn("dbo.Classes", "FortSaveProgression", c => c.String());
            AddColumn("dbo.Classes", "RefSaveProgression", c => c.String());
            AddColumn("dbo.Classes", "WillSaveProgression", c => c.String());
            AddColumn("dbo.Feats", "Type", c => c.String());
            AddColumn("dbo.RaceProperties", "PrimaryTrait", c => c.Boolean(nullable: false));
            AddColumn("dbo.Races", "Type", c => c.String());
            AlterColumn("dbo.Classes", "Name", c => c.String());
            AlterColumn("dbo.Classes", "Description", c => c.String());
            DropColumn("dbo.Classes", "PrimaryAbility");
            DropColumn("dbo.Races", "SubRace_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Races", "SubRace_Id", c => c.Int());
            AddColumn("dbo.Classes", "PrimaryAbility", c => c.String(nullable: false));
            DropForeignKey("dbo.ClassToSavingThrows", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.ClassToSavingThrows", "AbilityScore_Id", "dbo.AbilityScores");
            DropForeignKey("dbo.ClassToAbilityScores", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.ClassToAbilityScores", "AbilityScore_Id", "dbo.AbilityScores");
            DropIndex("dbo.ClassToSavingThrows", new[] { "AbilityScore_Id" });
            DropIndex("dbo.ClassToSavingThrows", new[] { "Class_Id" });
            DropIndex("dbo.ClassToAbilityScores", new[] { "AbilityScore_Id" });
            DropIndex("dbo.ClassToAbilityScores", new[] { "Class_Id" });
            AlterColumn("dbo.Classes", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Classes", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Races", "Type");
            DropColumn("dbo.RaceProperties", "PrimaryTrait");
            DropColumn("dbo.Feats", "Type");
            DropColumn("dbo.Classes", "WillSaveProgression");
            DropColumn("dbo.Classes", "RefSaveProgression");
            DropColumn("dbo.Classes", "FortSaveProgression");
            DropColumn("dbo.Classes", "BABProgression");
            DropColumn("dbo.Classes", "SkillsPerLevel");
            DropTable("dbo.ClassToSavingThrows");
            DropTable("dbo.ClassToAbilityScores");
            CreateIndex("dbo.Races", "SubRace_Id");
            AddForeignKey("dbo.Races", "SubRace_Id", "dbo.Races", "Race_Id");
        }
    }
}
