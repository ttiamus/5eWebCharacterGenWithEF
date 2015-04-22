using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("RaceToLanguages")]
    public class RaceToLanguagesMap
    {
        [Key]
        public int RaceToLanguage_Id { get; set; }

        [ForeignKey("Race_Id")]
        public Race Race { get; set; }
        public int Race_Id { get; set; }

        [ForeignKey("Language_Id")]
        public Language Language { get; set; }
        public int Language_Id { get; set; }
    }
}