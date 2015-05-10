using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IClassToAbilityScoreMappingRepository
    {
        IEnumerable<ClassToAbilityScoreMap> GetClassToAbilityScoreMaps();

        void CreateClassToAbilityScoreMap(ClassToAbilityScoreMap newClassToAbilityScoreMap);

        ClassToAbilityScoreMap GetClassToAbilityScoreMapById(int id);

        void UpdateClassToAbilityScoreMap(ClassToAbilityScoreMap toUpdate);

        void DeleteClassToAbilityScoreMap(int id);
    }
}