using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IClassToArmorMappingRepository
    {
        IEnumerable<ClassToArmorMap> GetClassToArmors();

        void CreateClassToArmor(ClassToArmorMap newClassToArmor);

        ClassToArmorMap GetClassToArmorById(int id);

        void UpdateClassToArmor(ClassToArmorMap toUpdate);

        void DeleteClassToArmor(int id);
    }
}