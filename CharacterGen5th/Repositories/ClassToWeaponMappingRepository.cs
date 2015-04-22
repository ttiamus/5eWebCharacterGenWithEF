using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class ClassToWeaponMappingRepository : AbstractRepository, IClassToWeaponMappingRepository
    {
        public ClassToWeaponMappingRepository(CharGenContext context) : base(context) { }

        public IEnumerable<ClassToWeaponMap> GetClassToWeapons()
        {
            return this.context.ClassToWeaponMappings.ToList();
        }

        public void CreateClassToWeapon(ClassToWeaponMap newClassToWeapon)
        {
            this.context.ClassToWeaponMappings.Add(newClassToWeapon);
            this.context.SaveChanges();
        }

        public ClassToWeaponMap GetClassToWeaponById(int id)
        {
            return this.context.ClassToWeaponMappings.Find(id);
        }

        public void UpdateClassToWeapon(ClassToWeaponMap toUpdate)
        {   
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteClassToWeapon(int id)
        {
            var toDelete = context.ClassToWeaponMappings.Find(id);
            this.context.ClassToWeaponMappings.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}