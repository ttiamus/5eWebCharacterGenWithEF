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
        public Background() { }

        [Key]
        public int Background_Id { get; set; }

        [Required()]
        public string Name { get; set; }

        [Required()]
        public virtual IEnumerable<BackgroundToSkillMap> SkillProficiencies { get; set; }

        [Required()]
        public virtual IEnumerable<BackgroundToLanguageMap> BackgroundLanguages { get; set; }

        [Required()]
        public virtual IEnumerable<BackgroundToItemMap> BackgroundEquipment { get; set; }
    }
}