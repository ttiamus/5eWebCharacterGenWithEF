using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetItems();

        void CreateItem(Item newItem);

        Item FindItemById(int id);

        void UpdateItem(Item toUpdate);

        void DeleteItem(int id);

    }
}
