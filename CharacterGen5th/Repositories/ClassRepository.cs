using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper.Models;
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

        public void CreateClass(Class newClass)
        {
            this.context.Classes.Add(newClass);
            this.context.SaveChanges();
        }

        public Class FindClassById(int id)
        {
            return this.context.Classes.Find(id);
        }

        public void UpdateClass(Class toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteClass(int id)
        {
            var toDelete = this.context.Classes.Find(id);
            this.context.Classes.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}