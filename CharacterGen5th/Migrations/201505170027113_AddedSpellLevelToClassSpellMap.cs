namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSpellLevelToClassSpellMap : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClassToSpells", "SpellLevel", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClassToSpells", "SpellLevel");
        }
    }
}
