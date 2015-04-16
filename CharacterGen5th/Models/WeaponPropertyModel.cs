using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("WeaponProperties")]
    public class WeaponPropertyModel
    {
        [Key]
        public int WeaponProperty_Id { get; set; }
        
        [Required()]
        public string Name { get; set; }

        [Required()]
        public string Description { get; set; }
    }
}