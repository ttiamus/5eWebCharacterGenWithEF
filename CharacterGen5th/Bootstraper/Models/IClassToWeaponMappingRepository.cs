using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IClassToWeaponMappingRepository
    {
        IEnumerable<ClassToWeaponMap> GetClassToWeapons();

        void CreateClassToWeapon(ClassToWeaponMap newClassToWeapon);

        ClassToWeaponMap GetClassToWeaponById(int id);

        void UpdateClassToWeapon(ClassToWeaponMap toUpdate);

        void DeleteClassToWeapon(int id);
    }
}