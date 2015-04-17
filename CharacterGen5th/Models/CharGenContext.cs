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

        public DbSet<AbilityScore> AbilityScores { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Feat> Feats { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<WeaponProperty> WeaponProperties { get; set; }
    }
}