using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Unity
{
    interface ISpellRepository
    {
        IEnumerable<Spell> GetSpells();

        void CreateSpell(Spell newSpell);

        Spell FindSpellById(int id);

        void UpdateSpell(Spell toUpdate);

        void DeleteSpell(int id);
    }
}
