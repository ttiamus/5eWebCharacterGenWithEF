using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class SpellRepository : AbstractRepository, ISpellRepository
    {
        public SpellRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Spell> GetSpells()
        {
            return this.context.Spells.ToList();
        }

        public void CreateSpell(Spell newSpell)
        {
            this.context.Spells.Add(newSpell);
            this.context.SaveChanges();
        }

        public Spell FindSpellById(int id)
        {
            return this.context.Spells.Find(id);
        }

        public void UpdateSpell(Spell toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteSpell(int id)
        {
            var toDelete = this.context.Spells.Find(id);
            this.context.Spells.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}