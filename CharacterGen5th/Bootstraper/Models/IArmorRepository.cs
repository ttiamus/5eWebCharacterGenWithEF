using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper
{
    interface IArmorRepository
    {
        IEnumerable<Armor> GetArmors();

        void CreateArmor(Armor newArmor);

        Armor FindArmorById(int id);

        void UpdateArmor(Armor toUpdate);

        void DeleteArmor(int id);
    }
}
