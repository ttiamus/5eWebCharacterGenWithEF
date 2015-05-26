using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IGodRepository
    {
        IEnumerable<God> GetGods();
        IEnumerable<God> GetGodsByAlignment(int alignmentId);
        void CreateGod(God newGod);
        God GetGodById(int id);
        void UpdateGod(God toUpdate);
        void DeleteGod(int id);
    }
}