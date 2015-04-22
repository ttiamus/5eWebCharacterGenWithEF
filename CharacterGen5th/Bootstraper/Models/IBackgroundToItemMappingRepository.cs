using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IBackgroundToItemMappingRepository
    {
        IEnumerable<BackgroundToItemMap> GetClassToItem();

        void CreateBackgroundToItem(BackgroundToItemMap newBackgroundToItem);

        BackgroundToItemMap GetBackgroundToItemById(int id);

        void UpdateBackgroundToItem(BackgroundToItemMap toUpdate);

        void DeleteBackgroundToItem(int id);
    }
}
