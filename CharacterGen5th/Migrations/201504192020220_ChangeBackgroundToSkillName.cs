namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBackgroundToSkillName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BackgroundToSkillMaping", newName: "BackgroundToSkill");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.BackgroundToSkill", newName: "BackgroundToSkillMaping");
        }
    }
}
