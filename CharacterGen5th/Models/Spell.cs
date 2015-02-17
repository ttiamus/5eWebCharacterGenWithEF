namespace CharacterGen5th.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Spell")]
    public partial class Spell
    {
        public int Id { get; set; }

        [Column("Spell Name")]
        [StringLength(25)]
        public string Spell_Name { get; set; }

        [StringLength(20)]
        public string Class { get; set; }

        [Column("Spell Level")]
        public int? Spell_Level { get; set; }

        [StringLength(10)]
        public string School { get; set; }

        [StringLength(10)]
        public string Component { get; set; }

        [StringLength(30)]
        public string Duration { get; set; }

        [StringLength(10)]
        public string Range { get; set; }

        [StringLength(30)]
        public string Target { get; set; }

        [StringLength(10)]
        public string Save { get; set; }

        [Column("Spell Resist")]
        public bool? Spell_Resist { get; set; }

        [StringLength(10)]
        public string Damage { get; set; }

        public string Description { get; set; }
    }
}
