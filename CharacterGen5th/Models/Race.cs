namespace CharacterGen5th.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Race
    {
        public int Id { get; set; }

        [Column("Race")]
        [Required]
        [StringLength(35)]
        public string Race1 { get; set; }
    }
}
