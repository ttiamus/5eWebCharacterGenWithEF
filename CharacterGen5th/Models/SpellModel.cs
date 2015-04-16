using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Spells")]
    public class SpellModel
    {
        [Key]
        public int Spell_Id { get; set; }

        [Required()]
        public string SpellName { get; set; }

        [Required()]
        public virtual IEnumerable<ClassModel> Classes { get; set; }

        public int SpellDc { get; set; }

        [Required()]
        public string CastTime { get; set; }

        [Required()]
        public string Duration { get; set; }

        public string Components { get; set; }

        [Required()]
        public string Range { get; set; }
        
        [Required()]
        public string Target { get; set; }

        [Required()]
        public string AreaOfEffect { get; set; }

    }
}