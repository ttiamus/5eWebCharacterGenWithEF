using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class ClassToArmorMappingRepository : AbstractRepository, IClassToArmorMappingRepository
    {
        public ClassToArmorMappingRepository(CharGenContext context) : base(context) { }

        public IEnumerable<ClassToArmorMap> GetClassToArmors()
        {
            return this.context.ClassToArmorMappings.ToList();
        }

        public void CreateClassToArmor(ClassToArmorMap newClassToArmor)
        {
            this.context.ClassToArmorMappings.Add(newClassToArmor);
            this.context.SaveChanges();
        }

        public ClassToArmorMap GetClassToArmorById(int id)
        {
            return this.context.ClassToArmorMappings.Find(id);
        }

        public void UpdateClassToArmor(ClassToArmorMap toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteClassToArmor(int id)
        {
            var toDelete = context.ClassToArmorMappings.Find(id);
            this.context.ClassToArmorMappings.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}