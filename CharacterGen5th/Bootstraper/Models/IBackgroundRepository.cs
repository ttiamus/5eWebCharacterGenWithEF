using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper
{
    interface IBackgroundRepository
    {
        IEnumerable<Background> GetBackgrounds();

        void CreateBackground(Background newBackground);

        Background FindBackgroundById(int id);

        void UpdateBackground(Background toUpdate);

        void DeleteBackground(int id);
    }
}
