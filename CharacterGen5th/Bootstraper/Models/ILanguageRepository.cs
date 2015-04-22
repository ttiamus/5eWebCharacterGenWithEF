using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface ILanguageRepository
    {
        IEnumerable<Language> GetLanguages();

        void CreateLanguage(Language newLanguage);

        Language FindLanguage(int id);

        void UpdateLanguage(Language toUpdate);

        void DeleteLanguage(int id);
    }
}
