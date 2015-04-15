using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CharacterGen5th.Models
{
    public class CharGenContext : DbContext
    {
        public CharGenContext() : base("CharGen5thCodeFirst")
        {

        }

        public DbSet<AbilityScoreModel> AbilityScores { get; set; }
        public DbSet<ArmorModel> Armors { get; set; }
        public DbSet<BackgroundModel> Backgrounds { get; set; }
        public DbSet<ClassModel> Classes { get; set; }
        public DbSet<FeatModel> Feats { get; set; }
        public DbSet<ItemModel> Items { get; set; }
        public DbSet<LanguageModel> Languages { get; set; }
        public DbSet<RaceModel> Races { get; set; }
        public DbSet<SizeModel> Sizes { get; set; }
        public DbSet<SkillModel> Skills { get; set; }
        public DbSet<SpellModel> Spells { get; set; }
        public DbSet<WeaponModel> Weapons { get; set; }
        public DbSet<WeaponPropertyModel> WeaponProperties { get; set; }
    }
}