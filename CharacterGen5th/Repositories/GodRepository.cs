using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class GodRepository : AbstractRepository, IGodRepository
    {
        public GodRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<God> GetGods()
        {
            return this.context.Gods.ToList();
        }

        public void CreateGod(God newGod)
        {
            this.context.Gods.Add(newGod);
            this.context.SaveChanges();
        }

        public God GetGodById(int id)
        {
            return this.context.Gods.Find(id);
        }

        public void UpdateGod(God toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteGod(int id)
        {
            var toDelete = context.Gods.Find(id);
            this.context.Gods.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}