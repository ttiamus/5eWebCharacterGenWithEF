namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removePrimaryTraitFromRaceProperty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.RaceProperties", "PrimaryTrait");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RaceProperties", "PrimaryTrait", c => c.Boolean(nullable: false));
        }
    }
}
