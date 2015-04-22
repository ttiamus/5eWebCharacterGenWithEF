using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class WeaponPropertyRepository : AbilityScoreRepository, IWeaponPropertyRepository
    {
        public WeaponPropertyRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<WeaponProperty> GetWeaponProperties()
        {
            return this.context.WeaponProperties.ToList();
        }

        public void CreateWeaponProperty(WeaponProperty newWeaponProperty)
        {
            this.context.WeaponProperties.Add(newWeaponProperty);
            this.context.SaveChanges();
        }

        public WeaponProperty FindWeaponPropertyById(int id)
        {
            return this.context.WeaponProperties.Find(id);
        }

        public void UpdateWeaponProperty(WeaponProperty toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteWeaponProperty(int id)
        {
            var toDelete = this.context.WeaponProperties.Find(id);
            this.context.WeaponProperties.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}