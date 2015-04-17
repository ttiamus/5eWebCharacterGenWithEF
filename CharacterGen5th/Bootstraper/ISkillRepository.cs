using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Unity
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetSkills();

        void CreateSkill(Skill newAbilityScore);

        Skill FindSkillById(int id);

        void UpdateSkill(Skill toUpdate);

        void DeleteSkill(int id);
    }
}