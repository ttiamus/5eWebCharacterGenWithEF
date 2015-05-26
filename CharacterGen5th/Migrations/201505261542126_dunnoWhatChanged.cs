namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dunnoWhatChanged : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Races", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Races", "Type", c => c.String());
        }
    }
}
