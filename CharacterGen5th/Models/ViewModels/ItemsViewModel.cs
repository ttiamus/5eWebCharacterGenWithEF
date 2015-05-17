using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Models.ViewModels
{
    public class ItemsViewModel
    {
        public IEnumerable<Armor> Armors { get; set; }
        public IEnumerable<Item> ItemsAmunition { get; set; }
        public IEnumerable<Item> ItemsGeneral { get; set; }
        public IEnumerable<Weapon> Weapons { get; set; }
    }
}