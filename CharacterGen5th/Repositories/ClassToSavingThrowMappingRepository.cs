using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class ClassToSavingThrowMappingRepository : AbstractRepository, IClassToSavingThrowMappingRepository
    {
        public ClassToSavingThrowMappingRepository(CharGenContext context) : base(context) { }

        public IEnumerable<ClassToSavingThrowMap> GetClassToSavingThrowMappings()
        {
            return this.context.ClassToSavingThrowMappings.ToList();
        }

        public void CreateClassToSavingThrowMap(ClassToSavingThrowMap newClassToSavingThrowMap)
        {
            this.context.ClassToSavingThrowMappings.Add(newClassToSavingThrowMap);
            this.context.SaveChanges();
        }

        public ClassToSavingThrowMap GetClassToSavingThrowMapById(int id)
        {
            return this.context.ClassToSavingThrowMappings.Find(id);
        }

        public void UpdateClassToSavingThrowMap(ClassToSavingThrowMap toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteClassToSavingThrowMap(int id)
        {
            var toDelete = context.ClassToSavingThrowMappings.Find(id);
            this.context.ClassToSavingThrowMappings.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}