using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("Gods")]
    public class God
    {
        [Key]
        public int God_Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        [ForeignKey("Alignment_Id")]
        public Alignment Alignment { get; set; }
        public int Alignment_Id { get; set; }

        public string Symbol { get; set; }

        public virtual IEnumerable<GodToDomainMap> Domains { get; set; }
        
    }
}