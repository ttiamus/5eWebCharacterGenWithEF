using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("ClassToWeapon")]
    public class ClassToWeaponMap
    {
        [Key]
        public int ClassToWeapon_Id { get; set; }

        [ForeignKey("Class_Id")]
        public Class Class { get; set; }
        public int Class_Id { get; set; }

        [ForeignKey("Weapon_Id")]
        public Weapon Weapon { get; set; }
        public int Weapon_Id { get; set; }
    }
}