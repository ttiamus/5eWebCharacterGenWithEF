namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedPropertiesFromClass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Classes", "SkillsPerLevel");
            DropColumn("dbo.Classes", "BABProgression");
            DropColumn("dbo.Classes", "FortSaveProgression");
            DropColumn("dbo.Classes", "RefSaveProgression");
            DropColumn("dbo.Classes", "WillSaveProgression");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Classes", "WillSaveProgression", c => c.String());
            AddColumn("dbo.Classes", "RefSaveProgression", c => c.String());
            AddColumn("dbo.Classes", "FortSaveProgression", c => c.String());
            AddColumn("dbo.Classes", "BABProgression", c => c.String());
            AddColumn("dbo.Classes", "SkillsPerLevel", c => c.Int(nullable: false));
        }
    }
}
