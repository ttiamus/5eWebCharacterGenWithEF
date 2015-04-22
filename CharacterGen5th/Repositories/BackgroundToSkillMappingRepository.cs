using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class BackgroundToSkillMappingRepository : AbstractRepository, IBackgroundToSkillMappingRepository
    {
        public BackgroundToSkillMappingRepository(CharGenContext context) : base(context) { }

        public IEnumerable<BackgroundToSkillMap> GetBackgroundToSkills()
        {
            return this.context.BackgroundToSkillMappings.ToList();
        }

        public void CreateBackgroundToSkill(BackgroundToSkillMap newBackgroundToSkill)
        {
            this.context.BackgroundToSkillMappings.Add(newBackgroundToSkill);
            this.context.SaveChanges();
        }

        public BackgroundToSkillMap GetBackgroundToSkillById(int id)
        {
            return this.context.BackgroundToSkillMappings.Find(id);
        }

        public void UpdateBackgroundToSkill(BackgroundToSkillMap toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteBackgroundToSkill(int id)
        {
            var toDelete = context.BackgroundToSkillMappings.Find(id);
            this.context.BackgroundToSkillMappings.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}