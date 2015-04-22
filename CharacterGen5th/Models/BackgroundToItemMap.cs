using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models
{
    [Table("BackgroundToItems")]
    public class BackgroundToItemMap
    {
        [Key]
        public int BackgroundToItem_Id { get; set; }

        [ForeignKey("Background_Id")]
        public Background Background { get; set; }
        public int Background_Id { get; set; }

        [ForeignKey("Item_Id")]
        public Item Item { get; set; }
        public int Item_Id { get; set; }
    }
}