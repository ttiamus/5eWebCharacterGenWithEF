namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveProfNeededFromWeapon : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Weapons", "ProficiencyNeeded");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Weapons", "ProficiencyNeeded", c => c.String(nullable: false));
        }
    }
}
