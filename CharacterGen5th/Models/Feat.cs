using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Feats")]
    public class Feat
    {
        public Feat() { }

        [Key]
        public int Feat_Id { get; set; }

        [Required()]
        public string Name { get; set; }
        
        public string Description { get; set; }

        public string Benefits { get; set; }

    }
}