using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Unity
{
    interface IFeatRepository
    {
        IEnumerable<Feat> GetFeats();

        void CreateFeat(Feat newSizes);

        Feat FindFeatById(int id);

        void UpdateFeat(Feat toUpdate);

        void DeleteFeat(int id);
    }
}
