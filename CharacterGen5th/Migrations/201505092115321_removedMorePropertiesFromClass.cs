namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedMorePropertiesFromClass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Classes", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Classes", "Description", c => c.String());
        }
    }
}
