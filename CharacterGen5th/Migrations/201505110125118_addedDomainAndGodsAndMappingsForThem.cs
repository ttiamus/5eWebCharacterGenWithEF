namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDomainAndGodsAndMappingsForThem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Domains",
                c => new
                    {
                        Domain_Id = c.Int(nullable: false, identity: true),
                        DomainName = c.String(),
                    })
                .PrimaryKey(t => t.Domain_Id);
            
            CreateTable(
                "dbo.Gods",
                c => new
                    {
                        God_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Title = c.String(),
                        Alignment_Id = c.Int(nullable: false),
                        Symbol = c.String(),
                    })
                .PrimaryKey(t => t.God_Id)
                .ForeignKey("dbo.Alignments", t => t.Alignment_Id, cascadeDelete: true)
                .Index(t => t.Alignment_Id);
            
            CreateTable(
                "dbo.GodToDomains",
                c => new
                    {
                        GodToDomainMap_Id = c.Int(nullable: false, identity: true),
                        God_Id = c.Int(nullable: false),
                        Domain_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GodToDomainMap_Id)
                .ForeignKey("dbo.Domains", t => t.Domain_Id, cascadeDelete: true)
                .ForeignKey("dbo.Gods", t => t.God_Id, cascadeDelete: true)
                .Index(t => t.God_Id)
                .Index(t => t.Domain_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GodToDomains", "God_Id", "dbo.Gods");
            DropForeignKey("dbo.GodToDomains", "Domain_Id", "dbo.Domains");
            DropForeignKey("dbo.Gods", "Alignment_Id", "dbo.Alignments");
            DropIndex("dbo.GodToDomains", new[] { "Domain_Id" });
            DropIndex("dbo.GodToDomains", new[] { "God_Id" });
            DropIndex("dbo.Gods", new[] { "Alignment_Id" });
            DropTable("dbo.GodToDomains");
            DropTable("dbo.Gods");
            DropTable("dbo.Domains");
        }
    }
}
