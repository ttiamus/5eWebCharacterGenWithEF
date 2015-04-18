namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCharacterModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alignments",
                c => new
                    {
                        Alignment_Id = c.Int(nullable: false, identity: true),
                        Alignment_Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Alignment_Id);
            
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Character_Id = c.Int(nullable: false, identity: true),
                        Inititive = c.Int(nullable: false),
                        Name = c.String(),
                        PlayerName = c.String(),
                        Eye = c.String(),
                        Hair = c.String(),
                        Age = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        AlignmentSelected_Alignment_Id = c.Int(),
                        BackgroundSelected_Background_Id = c.Int(),
                        RaceSelected_Race_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Character_Id)
                .ForeignKey("dbo.Alignments", t => t.AlignmentSelected_Alignment_Id)
                .ForeignKey("dbo.Backgrounds", t => t.BackgroundSelected_Background_Id)
                .ForeignKey("dbo.Races", t => t.RaceSelected_Race_Id)
                .Index(t => t.AlignmentSelected_Alignment_Id)
                .Index(t => t.BackgroundSelected_Background_Id)
                .Index(t => t.RaceSelected_Race_Id);
            
            AddColumn("dbo.Armors", "Character_Character_Id", c => c.Int());
            AddColumn("dbo.Classes", "Character_Character_Id", c => c.Int());
            AddColumn("dbo.Spells", "Character_Character_Id", c => c.Int());
            AddColumn("dbo.Feats", "Character_Character_Id", c => c.Int());
            AddColumn("dbo.Items", "Character_Character_Id", c => c.Int());
            AddColumn("dbo.Languages", "Character_Character_Id", c => c.Int());
            AddColumn("dbo.Weapons", "Character_Character_Id", c => c.Int());
            CreateIndex("dbo.Armors", "Character_Character_Id");
            CreateIndex("dbo.Classes", "Character_Character_Id");
            CreateIndex("dbo.Spells", "Character_Character_Id");
            CreateIndex("dbo.Feats", "Character_Character_Id");
            CreateIndex("dbo.Items", "Character_Character_Id");
            CreateIndex("dbo.Languages", "Character_Character_Id");
            CreateIndex("dbo.Weapons", "Character_Character_Id");
            AddForeignKey("dbo.Armors", "Character_Character_Id", "dbo.Characters", "Character_Id");
            AddForeignKey("dbo.Classes", "Character_Character_Id", "dbo.Characters", "Character_Id");
            AddForeignKey("dbo.Feats", "Character_Character_Id", "dbo.Characters", "Character_Id");
            AddForeignKey("dbo.Items", "Character_Character_Id", "dbo.Characters", "Character_Id");
            AddForeignKey("dbo.Languages", "Character_Character_Id", "dbo.Characters", "Character_Id");
            AddForeignKey("dbo.Spells", "Character_Character_Id", "dbo.Characters", "Character_Id");
            AddForeignKey("dbo.Weapons", "Character_Character_Id", "dbo.Characters", "Character_Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Weapons", "Character_Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Spells", "Character_Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Characters", "RaceSelected_Race_Id", "dbo.Races");
            DropForeignKey("dbo.Languages", "Character_Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Items", "Character_Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Feats", "Character_Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Classes", "Character_Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Characters", "BackgroundSelected_Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.Armors", "Character_Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Characters", "AlignmentSelected_Alignment_Id", "dbo.Alignments");
            DropIndex("dbo.Weapons", new[] { "Character_Character_Id" });
            DropIndex("dbo.Languages", new[] { "Character_Character_Id" });
            DropIndex("dbo.Items", new[] { "Character_Character_Id" });
            DropIndex("dbo.Feats", new[] { "Character_Character_Id" });
            DropIndex("dbo.Characters", new[] { "RaceSelected_Race_Id" });
            DropIndex("dbo.Characters", new[] { "BackgroundSelected_Background_Id" });
            DropIndex("dbo.Characters", new[] { "AlignmentSelected_Alignment_Id" });
            DropIndex("dbo.Spells", new[] { "Character_Character_Id" });
            DropIndex("dbo.Classes", new[] { "Character_Character_Id" });
            DropIndex("dbo.Armors", new[] { "Character_Character_Id" });
            DropColumn("dbo.Weapons", "Character_Character_Id");
            DropColumn("dbo.Languages", "Character_Character_Id");
            DropColumn("dbo.Items", "Character_Character_Id");
            DropColumn("dbo.Feats", "Character_Character_Id");
            DropColumn("dbo.Spells", "Character_Character_Id");
            DropColumn("dbo.Classes", "Character_Character_Id");
            DropColumn("dbo.Armors", "Character_Character_Id");
            DropTable("dbo.Characters");
            DropTable("dbo.Alignments");
        }
    }
}
