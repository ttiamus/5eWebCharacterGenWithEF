using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class RaceToRacePropertyMappingRepository : AbstractRepository, IRaceToRacePropertyMappingRepository
    {
        public RaceToRacePropertyMappingRepository(CharGenContext context) : base(context) { }

        public IEnumerable<RaceToRacePropertyMap> GetRaceToRaceProperties()
        {
            return this.context.RaceToRacePropertyMappings.ToList();
        }

        public void CreateRaceToRaceProperty(RaceToRacePropertyMap newRaceToRaceProperty)
        {
            this.context.RaceToRacePropertyMappings.Add(newRaceToRaceProperty);
            this.context.SaveChanges();
        }

        public RaceToRacePropertyMap GetRaceToRacePropertyById(int id)
        {
            return this.context.RaceToRacePropertyMappings.Find(id);
        }

        public void UpdateRaceToRaceProperty(RaceToRacePropertyMap toUpdate)
        {   
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteRaceToRaceProperty(int id)
        {
            var toDelete = context.RaceToRacePropertyMappings.Find(id);
            this.context.RaceToRacePropertyMappings.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}