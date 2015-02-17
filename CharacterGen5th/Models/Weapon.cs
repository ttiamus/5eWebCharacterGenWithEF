namespace CharacterGen5th.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Weapon
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Proficiency { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        [StringLength(20)]
        public string Damage { get; set; }

        [Column("Versatile Damage")]
        [StringLength(20)]
        public string Versatile_Damage { get; set; }

        [Column("Damage Type")]
        [StringLength(1)]
        public string Damage_Type { get; set; }

        [StringLength(50)]
        public string Properties { get; set; }

        [StringLength(10)]
        public string Range { get; set; }

        [Column("Max Range")]
        [StringLength(10)]
        public string Max_Range { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cost { get; set; }
    }
}
