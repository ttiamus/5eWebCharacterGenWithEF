using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("WeaponToWeaponProperties")]
    public class WeaponToWeaponPropertyMap
    {
        [Key]
        public int WeaponToWeaponProperty_Id { get; set; }

        [ForeignKey("Weapon_Id")]
        public Weapon Weapon { get; set; }
        public int Weapon_Id { get; set; }

        [ForeignKey("WeaponProperty_Id")]
        public WeaponProperty WeaponProperty { get; set; }
        public int WeaponProperty_Id { get; set; }
    }
}