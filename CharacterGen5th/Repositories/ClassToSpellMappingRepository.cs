using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class ClassToSpellMappingRepository : AbstractRepository, IClassToSpellMappingRepository
    {
        public ClassToSpellMappingRepository(CharGenContext context) : base(context) { }

        public IEnumerable<ClassToSpellMap> GetClassToSpells()
        {
            return this.context.ClassToSpellMappings.ToList();
        }

        public void CreateClassToSpell(ClassToSpellMap newClassToSpell)
        {
            this.context.ClassToSpellMappings.Add(newClassToSpell);
            this.context.SaveChanges();
        }

        public ClassToSpellMap GetClassToSpellById(int id)
        {
            return this.context.ClassToSpellMappings.Find(id);
        }

        public void UpdateClassToSpell(ClassToSpellMap toUpdate)
        {   
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteClassToSpell(int id)
        {
            var toDelete = context.ClassToSpellMappings.Find(id);
            this.context.ClassToSpellMappings.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}