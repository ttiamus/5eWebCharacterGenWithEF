using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Unity
{
    interface IBackgroundRepository
    {
        IEnumerable<Background> GetBackgrounds();

        void CreateBackground(Background newSizes);

        Background FindBackgroundById(int id);

        void UpdateBackground(Background toUpdate);

        void DeleteBackground(int id);
    }
}
