using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IRaceToLanguageMappingRepository
    {
        IEnumerable<RaceToLanguagesMap> GetRaceToRaceProperties();

        void CreateRaceToLanguage(RaceToLanguagesMap newRaceToLanguage);
            
        RaceToLanguagesMap GetRaceToLanguageById(int id);

        void UpdateRaceToLanguage(RaceToLanguagesMap toUpdate);

        void DeleteRaceToLanguage(int id);
    }
}
