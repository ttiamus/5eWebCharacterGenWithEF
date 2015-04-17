using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Unity
{
    public interface IWeaponPropertyRepository
    {
        IEnumerable<WeaponProperty> GetWeaponProperties();

        void CreateWeaponProperty(WeaponProperty newWeaponProperty);

        WeaponProperty FindWeaponPropertyById(int id);

        void UpdateWeaponProperty(WeaponProperty toUpdate);

        void DeleteWeaponProperty(int id);
    }
}