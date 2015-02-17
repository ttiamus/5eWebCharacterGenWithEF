namespace CharacterGen5th.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Class
    {
        [Key]
        public int Level { get; set; }

        [Column("Class")]
        [StringLength(20)]
        public string Class1 { get; set; }
    }
}
