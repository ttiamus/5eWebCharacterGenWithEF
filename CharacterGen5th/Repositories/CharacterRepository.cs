using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class CharacterRepository : AbstractRepository, ICharacterRepository
    {
        public CharacterRepository(CharGenContext context) : base(context)
        {
        }
        
        public IEnumerable<Character> GetCharacters()
        {
            return this.context.Characters.ToList();
        }

        public void CreateCharacter(Character newCharacter)
        {
            this.context.Characters.Add(newCharacter);
            this.context.SaveChanges();
        }

        public Character FindCharacterById(int id)
        {
            return this.context.Characters.Find(id);
        }

        public void UpdateCharacter(Character toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteCharacter(int id)
        {
            var toDelete = this.context.Characters.Find(id);
            this.context.Characters.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}