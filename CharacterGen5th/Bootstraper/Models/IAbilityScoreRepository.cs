using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper
{
    interface IAbilityScoreRepository
    {
        IEnumerable<AbilityScore> GetAbilityScores();
        
        void CreateAbilityScore(AbilityScore newAbilityScore);

        AbilityScore GetAbiltyScoreById (int id);

        void Update(AbilityScore toUpdate);

        void DeleteAbilityScore(int id);
    }
}
