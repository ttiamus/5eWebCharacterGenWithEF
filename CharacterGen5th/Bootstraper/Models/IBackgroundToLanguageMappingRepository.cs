using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IBackgroundToLanguageMappingRepository
    {
        IEnumerable<BackgroundToLanguageMap> GetClassToLanguages();

        void CreateBackgroundToSkill(BackgroundToLanguageMap newBackgroundToLanguage);

        BackgroundToLanguageMap GetBackgroundToLanguageById(int id);

        void UpdateBackgroundToLanguage(BackgroundToLanguageMap toUpdate);

        void DeleteBackgroundToLanguage(int id);
    }
}
