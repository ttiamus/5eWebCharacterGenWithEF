using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Characters")]
    public class Character
    {
       /* public Character() { }

        [Key]
        public int Character_Id { get; set; }

        public List<int> AbilityScores { get; set; }    //List of ints in order of Str Dex Con Int Wis Cha
                                                        //May need to make an abillity score map with foreign keys Character_Id AbilityScore_Id and int value
        [ForeignKey("Alignment_Id")]
        public Alignment AlignmentSelected { get; set; }
        public int? Alignment_Id { get; set; }

        public List<Armor> ArmorSelected { get; set; }      //Can calculate AC from this or make it's own value to store in database

        [ForeignKey("Background_Id")]
        public Background BackgroundSelected { get; set; }
        public int? Background_Id { get; set; }

        public IEnumerable<Class> ClassesSelected { get; set; }    //List of chosen classes. May need to make a mapping class with Class_Id and int LevelsTaken

        public IEnumerable<Feat> FeatsSelected { get; set; }

        public int Inititive { get; set; }

        public IEnumerable<Item> ItemsSelected { get; set; }

        public IEnumerable<Language> LanguagesSelected { get; set; }
        
        [ForeignKey("Race_Id")]
        public Race RaceSelected { get; set; }
        public int? Race_Id { get; set; }

        public IEnumerable<Spell> SpellList { get; set; }

        public IEnumerable<Weapon> WeaponsSelected { get; set; }

        //Demographic Information
        public string Name { get; set; }

        public string PlayerName { get; set; }

        public string Eye { get; set; }

        public string Hair { get; set; }

        public int Age { get; set; }

        public int Weight { get; set; }*/
    }
}