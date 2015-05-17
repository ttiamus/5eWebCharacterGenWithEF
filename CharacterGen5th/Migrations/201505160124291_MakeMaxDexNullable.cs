namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeMaxDexNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Armors", "MaxDexMod", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Armors", "MaxDexMod", c => c.Int(nullable: false));
        }
    }
}
