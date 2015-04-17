using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Unity
{
    interface IWeaponRepository
    {
        IEnumerable<Weapon> GetWeapons();

        void CreateWeapon(Weapon newWeapon);

        Weapon FindWeaponById(int id);

        void UpdateWeapon(Weapon toUpdate);

        void DeleteWeapon(int id);
    }
}
