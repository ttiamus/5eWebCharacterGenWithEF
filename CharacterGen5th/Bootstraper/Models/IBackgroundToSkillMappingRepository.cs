using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IBackgroundToSkillMappingRepository
    {
        IEnumerable<BackgroundToSkillMap> GetBackgroundToSkills();

        void CreateBackgroundToSkill(BackgroundToSkillMap newBackgroundToSkill);

        BackgroundToSkillMap GetBackgroundToSkillById(int id);

        void UpdateBackgroundToSkill(BackgroundToSkillMap toUpdate);

        void DeleteBackgroundToSkill(int id);
    }
}