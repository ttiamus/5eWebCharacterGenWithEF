namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class readdedCharacterModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Character_Id = c.Int(nullable: false, identity: true),
                        Str = c.Int(nullable: false),
                        Dex = c.Int(nullable: false),
                        Con = c.Int(nullable: false),
                        Int = c.Int(nullable: false),
                        Wis = c.Int(nullable: false),
                        Cha = c.Int(nullable: false),
                        Alignment_Id = c.Int(),
                        Inititive = c.Int(nullable: false),
                        Race_Id = c.Int(),
                        Name = c.String(),
                        PlayerName = c.String(),
                        Eye = c.String(),
                        Hair = c.String(),
                        Age = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Character_Id)
                .ForeignKey("dbo.Alignments", t => t.Alignment_Id)
                .ForeignKey("dbo.Races", t => t.Race_Id)
                .Index(t => t.Alignment_Id)
                .Index(t => t.Race_Id);
            
            AddColumn("dbo.Armors", "Character_Character_Id", c => c.Int());
            CreateIndex("dbo.Armors", "Character_Character_Id");
            AddForeignKey("dbo.Armors", "Character_Character_Id", "dbo.Characters", "Character_Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Armors", "Character_Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Characters", "Alignment_Id", "dbo.Alignments");
            DropIndex("dbo.Characters", new[] { "Race_Id" });
            DropIndex("dbo.Characters", new[] { "Alignment_Id" });
            DropIndex("dbo.Armors", new[] { "Character_Character_Id" });
            DropColumn("dbo.Armors", "Character_Character_Id");
            DropTable("dbo.Characters");
        }
    }
}
