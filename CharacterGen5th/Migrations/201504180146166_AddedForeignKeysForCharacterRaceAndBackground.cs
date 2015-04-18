namespace CharacterGen5th.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeysForCharacterRaceAndBackground : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AbilityScores", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Skills", "Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.Armors", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.Classes", "Spell_Id", "dbo.Spells");
            DropForeignKey("dbo.Items", "Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.Languages", "Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.Weapons", "Class_Id", "dbo.Classes");
            DropIndex("dbo.AbilityScores", new[] { "Race_Id" });
            DropIndex("dbo.Skills", new[] { "Background_Id" });
            DropIndex("dbo.Armors", new[] { "Class_Id" });
            DropIndex("dbo.Classes", new[] { "Spell_Id" });
            DropIndex("dbo.Items", new[] { "Background_Id" });
            DropIndex("dbo.Languages", new[] { "Race_Id" });
            DropIndex("dbo.Languages", new[] { "Background_Id" });
            DropIndex("dbo.Weapons", new[] { "Class_Id" });
            RenameColumn(table: "dbo.Characters", name: "AlignmentSelected_Alignment_Id", newName: "Alignment_Id");
            RenameColumn(table: "dbo.Characters", name: "BackgroundSelected_Background_Id", newName: "Background_Id");
            RenameColumn(table: "dbo.Characters", name: "RaceSelected_Race_Id", newName: "Race_Id");
            RenameColumn(table: "dbo.Classes", name: "Character_Character_Id", newName: "Character_Id");
            RenameColumn(table: "dbo.Feats", name: "Character_Character_Id", newName: "Character_Id");
            RenameColumn(table: "dbo.Items", name: "Character_Character_Id", newName: "Character_Id");
            RenameColumn(table: "dbo.Languages", name: "Character_Character_Id", newName: "Character_Id");
            RenameColumn(table: "dbo.Spells", name: "Character_Character_Id", newName: "Character_Id");
            RenameColumn(table: "dbo.Weapons", name: "Character_Character_Id", newName: "Character_Id");
            RenameIndex(table: "dbo.Classes", name: "IX_Character_Character_Id", newName: "IX_Character_Id");
            RenameIndex(table: "dbo.Characters", name: "IX_AlignmentSelected_Alignment_Id", newName: "IX_Alignment_Id");
            RenameIndex(table: "dbo.Characters", name: "IX_BackgroundSelected_Background_Id", newName: "IX_Background_Id");
            RenameIndex(table: "dbo.Characters", name: "IX_RaceSelected_Race_Id", newName: "IX_Race_Id");
            RenameIndex(table: "dbo.Spells", name: "IX_Character_Character_Id", newName: "IX_Character_Id");
            RenameIndex(table: "dbo.Feats", name: "IX_Character_Character_Id", newName: "IX_Character_Id");
            RenameIndex(table: "dbo.Items", name: "IX_Character_Character_Id", newName: "IX_Character_Id");
            RenameIndex(table: "dbo.Languages", name: "IX_Character_Character_Id", newName: "IX_Character_Id");
            RenameIndex(table: "dbo.Weapons", name: "IX_Character_Character_Id", newName: "IX_Character_Id");
            AddColumn("dbo.WeaponProperties", "Weapon_Id", c => c.Int());
            AlterColumn("dbo.AbilityScores", "Race_Id", c => c.Int());
            AlterColumn("dbo.AbilityScores", "Skill_Id", c => c.Int());
            AlterColumn("dbo.Skills", "AbilityScore_Id", c => c.Int());
            AlterColumn("dbo.Skills", "Background_Id", c => c.Int());
            AlterColumn("dbo.Armors", "Class_Id", c => c.Int());
            AlterColumn("dbo.Classes", "Spell_Id", c => c.Int());
            AlterColumn("dbo.Items", "Background_Id", c => c.Int());
            AlterColumn("dbo.Languages", "Race_Id", c => c.Int());
            AlterColumn("dbo.Languages", "Background_Id", c => c.Int());
            AlterColumn("dbo.Weapons", "Class_Id", c => c.Int());
            CreateIndex("dbo.AbilityScores", "Race_Id");
            CreateIndex("dbo.Skills", "Background_Id");
            CreateIndex("dbo.Armors", "Class_Id");
            CreateIndex("dbo.Classes", "Spell_Id");
            CreateIndex("dbo.Items", "Background_Id");
            CreateIndex("dbo.Languages", "Race_Id");
            CreateIndex("dbo.Languages", "Background_Id");
            CreateIndex("dbo.WeaponProperties", "Weapon_Id");
            CreateIndex("dbo.Weapons", "Class_Id");
            AddForeignKey("dbo.WeaponProperties", "Weapon_Id", "dbo.Weapons", "Weapon_Id");
            AddForeignKey("dbo.AbilityScores", "Race_Id", "dbo.Races", "Race_Id");
            AddForeignKey("dbo.Skills", "Background_Id", "dbo.Backgrounds", "Background_Id");
            AddForeignKey("dbo.Armors", "Class_Id", "dbo.Classes", "Class_Id");
            AddForeignKey("dbo.Classes", "Spell_Id", "dbo.Spells", "Spell_Id");
            AddForeignKey("dbo.Items", "Background_Id", "dbo.Backgrounds", "Background_Id");
            AddForeignKey("dbo.Languages", "Background_Id", "dbo.Backgrounds", "Background_Id");
            AddForeignKey("dbo.Weapons", "Class_Id", "dbo.Classes", "Class_Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Weapons", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.Languages", "Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.Items", "Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.Classes", "Spell_Id", "dbo.Spells");
            DropForeignKey("dbo.Armors", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.Skills", "Background_Id", "dbo.Backgrounds");
            DropForeignKey("dbo.AbilityScores", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.WeaponProperties", "Weapon_Id", "dbo.Weapons");
            DropIndex("dbo.Weapons", new[] { "Class_Id" });
            DropIndex("dbo.WeaponProperties", new[] { "Weapon_Id" });
            DropIndex("dbo.Languages", new[] { "Background_Id" });
            DropIndex("dbo.Languages", new[] { "Race_Id" });
            DropIndex("dbo.Items", new[] { "Background_Id" });
            DropIndex("dbo.Classes", new[] { "Spell_Id" });
            DropIndex("dbo.Armors", new[] { "Class_Id" });
            DropIndex("dbo.Skills", new[] { "Background_Id" });
            DropIndex("dbo.AbilityScores", new[] { "Race_Id" });
            AlterColumn("dbo.Weapons", "Class_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Languages", "Background_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Languages", "Race_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "Background_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Classes", "Spell_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Armors", "Class_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Skills", "Background_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Skills", "AbilityScore_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.AbilityScores", "Skill_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.AbilityScores", "Race_Id", c => c.Int(nullable: false));
            DropColumn("dbo.WeaponProperties", "Weapon_Id");
            RenameIndex(table: "dbo.Weapons", name: "IX_Character_Id", newName: "IX_Character_Character_Id");
            RenameIndex(table: "dbo.Languages", name: "IX_Character_Id", newName: "IX_Character_Character_Id");
            RenameIndex(table: "dbo.Items", name: "IX_Character_Id", newName: "IX_Character_Character_Id");
            RenameIndex(table: "dbo.Feats", name: "IX_Character_Id", newName: "IX_Character_Character_Id");
            RenameIndex(table: "dbo.Spells", name: "IX_Character_Id", newName: "IX_Character_Character_Id");
            RenameIndex(table: "dbo.Characters", name: "IX_Race_Id", newName: "IX_RaceSelected_Race_Id");
            RenameIndex(table: "dbo.Characters", name: "IX_Background_Id", newName: "IX_BackgroundSelected_Background_Id");
            RenameIndex(table: "dbo.Characters", name: "IX_Alignment_Id", newName: "IX_AlignmentSelected_Alignment_Id");
            RenameIndex(table: "dbo.Classes", name: "IX_Character_Id", newName: "IX_Character_Character_Id");
            RenameColumn(table: "dbo.Weapons", name: "Character_Id", newName: "Character_Character_Id");
            RenameColumn(table: "dbo.Spells", name: "Character_Id", newName: "Character_Character_Id");
            RenameColumn(table: "dbo.Languages", name: "Character_Id", newName: "Character_Character_Id");
            RenameColumn(table: "dbo.Items", name: "Character_Id", newName: "Character_Character_Id");
            RenameColumn(table: "dbo.Feats", name: "Character_Id", newName: "Character_Character_Id");
            RenameColumn(table: "dbo.Classes", name: "Character_Id", newName: "Character_Character_Id");
            RenameColumn(table: "dbo.Characters", name: "Race_Id", newName: "RaceSelected_Race_Id");
            RenameColumn(table: "dbo.Characters", name: "Background_Id", newName: "BackgroundSelected_Background_Id");
            RenameColumn(table: "dbo.Characters", name: "Alignment_Id", newName: "AlignmentSelected_Alignment_Id");
            CreateIndex("dbo.Weapons", "Class_Id");
            CreateIndex("dbo.Languages", "Background_Id");
            CreateIndex("dbo.Languages", "Race_Id");
            CreateIndex("dbo.Items", "Background_Id");
            CreateIndex("dbo.Classes", "Spell_Id");
            CreateIndex("dbo.Armors", "Class_Id");
            CreateIndex("dbo.Skills", "Background_Id");
            CreateIndex("dbo.AbilityScores", "Race_Id");
            AddForeignKey("dbo.Weapons", "Class_Id", "dbo.Classes", "Class_Id", cascadeDelete: true);
            AddForeignKey("dbo.Languages", "Background_Id", "dbo.Backgrounds", "Background_Id", cascadeDelete: true);
            AddForeignKey("dbo.Items", "Background_Id", "dbo.Backgrounds", "Background_Id", cascadeDelete: true);
            AddForeignKey("dbo.Classes", "Spell_Id", "dbo.Spells", "Spell_Id", cascadeDelete: true);
            AddForeignKey("dbo.Armors", "Class_Id", "dbo.Classes", "Class_Id", cascadeDelete: true);
            AddForeignKey("dbo.Skills", "Background_Id", "dbo.Backgrounds", "Background_Id", cascadeDelete: true);
            AddForeignKey("dbo.AbilityScores", "Race_Id", "dbo.Races", "Race_Id", cascadeDelete: true);
        }
    }
}
