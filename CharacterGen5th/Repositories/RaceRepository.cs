using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class RaceRepository : AbstractRepository, IRaceRepository
    {
        public RaceRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Race> GetRaces()
        {
            return this.context.Races.ToList();
        }

        public void CreateRace(Race newRace)
        {
            this.context.Races.Add(newRace);
            this.context.SaveChanges();
        }

        public Race FindRaceById(int id)
        {
            return this.context.Races.Find(id);
        }

        public void UpdateRace(Race toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteRace(int id)
        {
            var toDelete = context.Races.Find(id);
            this.context.Races.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}