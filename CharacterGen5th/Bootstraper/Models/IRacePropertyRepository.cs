using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IRacePropertyRepository
    {
        IEnumerable<RaceProperty> GetRaceProperties();

        void CreateRaceProperty(RaceProperty newArmor);

        RaceProperty FindArmorById(int id);

        void UpdateArmor(RaceProperty toUpdate);

        void DeleteRaceProperty(int id);
    }
}
