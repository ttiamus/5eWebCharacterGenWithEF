using CharacterGen5th.Models;
using CharacterGen5th.Unity;
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

        public void CreateRace(Race newSizes)
        {
            this.context.Races.Add(newSizes);
        }

        public Race FindRaceById(int id)
        {
            return this.context.Races.Find(id);
        }

        public void UpdateRace(Race toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
        }

        public void DeleteRace(int id)
        {
            var toDelete = context.Races.Find(id);
            this.context.Races.Remove(toDelete);
        }
    }
}