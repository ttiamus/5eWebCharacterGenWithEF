using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Unity
{
    interface IItemRepository
    {
        IEnumerable<Item> GetItems();

        void CreateItem(Item newSizes);

        Item FindItemById(int id);

        void UpdateItem(Item toUpdate);

        void DeleteItem(int id);

    }
}
