using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class ClassToAbilityScoreMappingRepository : AbstractRepository, IClassToAbilityScoreMappingRepository
    {
        public ClassToAbilityScoreMappingRepository(CharGenContext context) : base(context) { }

        public IEnumerable<Models.ClassToAbilityScoreMap> GetClassToAbilityScoreMaps()
        {
            return this.context.ClassToAbilityScoreMappings.ToList();
        }

        public void CreateClassToAbilityScoreMap(Models.ClassToAbilityScoreMap newClassToAbilityScoreMap)
        {
            this.context.ClassToAbilityScoreMappings.Add(newClassToAbilityScoreMap);
            this.context.SaveChanges();
        }

        public Models.ClassToAbilityScoreMap GetClassToAbilityScoreMapById(int id)
        {
            return this.context.ClassToAbilityScoreMappings.Find(id);
        }

        public void UpdateClassToAbilityScoreMap(Models.ClassToAbilityScoreMap toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteClassToAbilityScoreMap(int id)
        {
            var toDelete = context.ClassToAbilityScoreMappings.Find(id);
            this.context.ClassToAbilityScoreMappings.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}