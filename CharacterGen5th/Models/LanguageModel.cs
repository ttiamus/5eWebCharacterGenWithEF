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
    public class LanguageModel
    {
        [Key]
        public int Language_Id { get; set; }

        [Required()]
        public string Name { get; set; }

        [ForeignKey("Race_Id")]
        public virtual LanguageModel Race { get; set; }
        public int Race_Id { get; set; }

        [ForeignKey("Background_Id")]
        public virtual BackgroundModel Background { get; set; }
        public int Background_Id { get; set; }
    }
}