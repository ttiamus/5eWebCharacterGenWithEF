using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Sizes")]
    public class SizeModel
    {
        [Key]
        public int Size_Id { get; set; }

        [Required()]
        public string Size { get; set; }

        [Required()]
        public bool AcIncrease { get; set; }

        [Required()]
        public int AcMod { get; set; }
    }
}