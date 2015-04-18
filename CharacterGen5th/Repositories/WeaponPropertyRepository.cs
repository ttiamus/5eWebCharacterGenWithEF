using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper;
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
        }

        public WeaponProperty FindWeaponPropertyById(int id)
        {
            return this.context.WeaponProperties.Find(id);
        }

        public void UpdateWeaponProperty(WeaponProperty toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
        }

        public void DeleteWeaponProperty(int id)
        {
            var toDelete = this.context.WeaponProperties.Find(id);
            this.context.WeaponProperties.Remove(toDelete);
        }
    }
}