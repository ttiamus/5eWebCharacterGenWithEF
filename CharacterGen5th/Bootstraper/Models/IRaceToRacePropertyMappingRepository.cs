using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IRaceToRacePropertyMappingRepository
    {
        IEnumerable<RaceToRacePropertyMap> GetRaceToRaceProperties();

        void CreateRaceToRaceProperty(RaceToRacePropertyMap newRaceToRaceProperty);

        RaceToRacePropertyMap GetRaceToRacePropertyById(int id);

        void UpdateRaceToRaceProperty(RaceToRacePropertyMap toUpdate);

        void DeleteRaceToRaceProperty(int id);
    }
}
