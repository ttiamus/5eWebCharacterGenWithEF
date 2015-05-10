using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IClassToSavingThrowMappingRepository
    {
        IEnumerable<ClassToSavingThrowMap> GetClassToSavingThrowMappings();

        void CreateClassToSavingThrowMap(ClassToSavingThrowMap newClassToSavingThrowMap);

        ClassToSavingThrowMap GetClassToSavingThrowMapById(int id);

        void UpdateClassToSavingThrowMap(ClassToSavingThrowMap toUpdate);

        void DeleteClassToSavingThrowMap(int id);
    }
}