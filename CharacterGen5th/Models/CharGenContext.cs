using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CharacterGen5th.Models
{
    public class CharGenContext : DbContext
    {
        public CharGenContext() : base("CharacterGen")
        {

        }

        public DbSet<AbilityScore> AbilityScores { get; set; }
        public DbSet<Alignment> Alignments { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Background> Backgrounds { get; set; }
        //public DbSet<Character> Characters { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<Feat> Feats { get; set; }
        public DbSet<God> Gods { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceProperty> RaceProperties { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<WeaponProperty> WeaponProperties { get; set; }

        //Mapping
        public DbSet<BackgroundToItemMap> BackgroundToItemMappings { get; set; }
        public DbSet<BackgroundToLanguageMap> BackgroundToLanguageMappings { get; set; }
        public DbSet<BackgroundToSkillMap> BackgroundToSkillMappings { get; set; }
        public DbSet<ClassToAbilityScoreMap> ClassToAbilityScoreMappings { get; set; }
        public DbSet<ClassToArmorMap> ClassToArmorMappings { get; set; }
        public DbSet<ClassToSavingThrowMap> ClassToSavingThrowMappings { get; set; }
        public DbSet<ClassToSpellMap> ClassToSpellMappings { get; set; }
        public DbSet<ClassToWeaponMap> ClassToWeaponMappings { get; set; }
        public DbSet<GodToDomainMap> GodToDoaminMappings { get; set; }
        public DbSet<RaceToAbililtyScoreMap> RaceToAbililtyScoreMappings { get; set; }
        public DbSet<RaceToLanguagesMap> RaceToLanguagesMappings { get; set; }
        public DbSet<RaceToRacePropertyMap> RaceToRacePropertyMappings { get; set; }
    }
}