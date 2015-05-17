namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSpellDcToBool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Spells", "SpellDc", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Spells", "SpellDc", c => c.Int(nullable: false));
        }
    }
}
