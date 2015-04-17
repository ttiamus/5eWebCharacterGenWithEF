using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Backgrounds")]
    public class Background
    {
        [Key]
        public int Background_Id { get; set; }

        [Required()]
        public string Name { get; set; }

        [Required()]
        public virtual IEnumerable<Skill> SkillProficiencies { get; set; }

        [Required()]
        public virtual IEnumerable<Language> Languages { get; set; }

        [Required()]
        public virtual IEnumerable<Item> Equipment { get; set; }
    }
}