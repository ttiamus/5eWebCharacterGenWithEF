using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper
{
    interface ICharacterRepository
    {
        IEnumerable<Character> GetCharacters();

        void CreateCharacter(Character newCharacter);

        Character FindCharacterById(int id);

        void UpdateCharacter(Character toUpdate);

        void DeleteCharacter(int id);
    }
}
