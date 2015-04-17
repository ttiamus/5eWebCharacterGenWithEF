using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Unity
{
    interface IRaceRepository
    {
        IEnumerable<Race> GetRaces();

        void CreateRace(Race newSizes);

        Race FindRaceById(int id);

        void UpdateRace(Race toUpdate);

        void DeleteRace(int id);
    }
}
