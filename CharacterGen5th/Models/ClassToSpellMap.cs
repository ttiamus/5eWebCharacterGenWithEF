using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("ClassToSpells")]
    public class ClassToSpellMap
    {
        [Key]
        public int ClassToSpell_Id { get; set; }

        [ForeignKey("Class_Id")]
        public Class Class { get; set; }
        public int Class_Id { get; set; }

        [ForeignKey("Spell_Id")]
        public Spell Spell { get; set; }
        public int Spell_Id { get; set; }
    }
}