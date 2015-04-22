using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class RaceToAbilityScoreMappingRepository : AbstractRepository, IRaceToAbilityScoreMappingRepository
    {
        public RaceToAbilityScoreMappingRepository(CharGenContext context) : base(context) { }

        public IEnumerable<RaceToAbililtyScoreMap> GetRaceToAbilityScores()
        {
            return this.context.RaceToAbililtyScoreMappings.ToList();
        }

        public void CreateRaceToAbilityScore(RaceToAbililtyScoreMap newRaceToAbililtyScore)
        {
            this.context.RaceToAbililtyScoreMappings.Add(newRaceToAbililtyScore);
            this.context.SaveChanges();
        }

        public RaceToAbililtyScoreMap GetRaceToAbilityScoreById(int id)
        {
            return this.context.RaceToAbililtyScoreMappings.Find(id);
        }

        public void UpdateRaceToAbilityScore(RaceToAbililtyScoreMap toUpdate)
        {   
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteRaceToAbilityScore(int id)
        {
            var toDelete = context.RaceToAbililtyScoreMappings.Find(id);
            this.context.RaceToAbililtyScoreMappings.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}