using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class SkillRepository : AbstractRepository, ISkillRepository
    {
        public SkillRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Skill> GetSkills()
        {
            return this.context.Skills.ToList();
        }

        public void CreateSkill(Skill newSkill)
        {
            this.context.Skills.Add(newSkill);
            this.context.SaveChanges();
        }

        public Skill FindSkillById(int id)
        {
            return this.context.Skills.Find(id);
        }

        public void UpdateSkill(Skill toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteSkill(int id)
        {
            var toDelete = this.context.Skills.Find(id);
            this.context.Skills.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}