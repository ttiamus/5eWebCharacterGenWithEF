using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class WeaponRepository : AbstractRepository , IWeaponRepository
    {
        public WeaponRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Weapon> GetWeapons()
        {
            return this.context.Weapons.ToList();
        }

        public void CreateWeapon(Weapon newWeapon)
        {
            this.context.Weapons.Add(newWeapon);
        }

        public Weapon FindWeaponById(int id)
        {
            return this.context.Weapons.Find(id);
        }

        public void UpdateWeapon(Weapon toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
        }

        public void DeleteWeapon(int id)
        {
            var toDelete = this.context.Weapons.Find(id);
            this.context.Weapons.Remove(toDelete);
        }
    }
}