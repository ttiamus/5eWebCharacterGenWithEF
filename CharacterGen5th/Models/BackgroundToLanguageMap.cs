using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("BackgroundToLanguages")]
    public class BackgroundToLanguageMap
    {
        [Key]
        public int BackgroundToLanguage_Id { get; set; }

        [ForeignKey("Background_Id")]
        public Background Background { get; set; }
        public int Background_Id { get; set; }

        [ForeignKey("Language_Id")]
        public Language Language { get; set; }
        public int Language_Id { get; set; }
    }
}