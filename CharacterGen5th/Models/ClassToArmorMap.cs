using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("ClassToArmor")]
    public class ClassToArmorMap
    {
        [Key]
        public int ClassToArmor_Id { get; set; }

        [ForeignKey("Class_Id")]
        public Class Class { get; set; }
        public int Class_Id { get; set; }

        [ForeignKey("Armor_Id")]
        public Armor Armor { get; set; }
        public int Armor_Id { get; set; }
    }
}