using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class BackgroundToItemMappingRepository : AbstractRepository, IBackgroundToItemMappingRepository
    {
        public BackgroundToItemMappingRepository(CharGenContext context) : base(context) { }

        public IEnumerable<BackgroundToItemMap> GetClassToItem()
        {
            return this.context.BackgroundToItemMappings.ToList();
        }

        public void CreateBackgroundToItem(BackgroundToItemMap newBackgroundToItem)
        {
            this.context.BackgroundToItemMappings.Add(newBackgroundToItem);
            this.context.SaveChanges();
        }

        public BackgroundToItemMap GetBackgroundToItemById(int id)
        {
            return this.context.BackgroundToItemMappings.Find(id);
        }

        public void UpdateBackgroundToItem(BackgroundToItemMap toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteBackgroundToItem(int id)
        {
            var toDelete = context.BackgroundToItemMappings.Find(id);
            this.context.BackgroundToItemMappings.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}