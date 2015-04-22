using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Languages")]
    public class Language
    {
        public Language() { }

        [Key]
        public int Language_Id { get; set; }

        [Required()]
        public string Name { get; set; }

        public virtual IEnumerable<RaceToLanguagesMap> RacialLanguages { get; set; }

        public virtual IEnumerable<BackgroundToLanguageMap> BackgroundLanguages { get; set; }
    }
}