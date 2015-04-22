using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IRaceToAbilityScoreMappingRepository
    {
        IEnumerable<RaceToAbililtyScoreMap> GetRaceToAbilityScores();

        void CreateRaceToAbilityScore(RaceToAbililtyScoreMap newRaceToAbilityScore);

        RaceToAbililtyScoreMap GetRaceToAbilityScoreById(int id);

        void UpdateRaceToAbilityScore(RaceToAbililtyScoreMap toUpdate);

        void DeleteRaceToAbilityScore(int id);
    }
}