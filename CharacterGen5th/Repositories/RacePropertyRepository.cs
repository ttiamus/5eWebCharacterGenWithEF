using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class RacePropertyRepository : AbstractRepository, IRacePropertyRepository
    {
        public RacePropertyRepository(CharGenContext context) : base(context) { }

        public IEnumerable<RaceProperty> GetRaceProperties()
        {
            return this.context.RaceProperties.ToList();
        }

        public void CreateRaceProperty(RaceProperty newArmor)
        {
            this.context.RaceProperties.Add(newArmor);
            this.context.SaveChanges();
        }

        public RaceProperty FindArmorById(int id)
        {
            return this.context.RaceProperties.Find(id);
        }

        public void UpdateArmor(RaceProperty toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteRaceProperty(int id)
        {
            var toDelete = this.context.RaceProperties.Find(id);
            this.context.RaceProperties.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}