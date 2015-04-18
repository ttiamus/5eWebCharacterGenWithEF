using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class ClassRepository : AbstractRepository, IClassRepository
    {
        public ClassRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Class> GetClasses()
        {
            return this.context.Classes.ToList();
        }

        public void CreateFeat(Class newClass)
        {
            this.context.Classes.Add(newClass);
        }

        public Class FindFeatById(int id)
        {
            return this.context.Classes.Find(id);
        }

        public void UpdateFeat(Class toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
        }

        public void DeleteFeat(int id)
        {
            var toDelete = this.context.Classes.Find(id);
            this.context.Classes.Remove(toDelete);
        }
    }
}