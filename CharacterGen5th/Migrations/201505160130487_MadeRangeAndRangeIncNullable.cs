namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeRangeAndRangeIncNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Weapons", "Range", c => c.Int());
            AlterColumn("dbo.Weapons", "RangeIncrement", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Weapons", "RangeIncrement", c => c.Int(nullable: false));
            AlterColumn("dbo.Weapons", "Range", c => c.Int(nullable: false));
        }
    }
}
