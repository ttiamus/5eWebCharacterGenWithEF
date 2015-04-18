using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class ArmorRepository : AbstractRepository, IArmorRepository
    {
        public ArmorRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Armor> GetArmors()
        {
            return this.context.Armors.ToList();
        }

        public void CreateArmor(Armor newArmor)
        {
            this.context.Armors.Add(newArmor);
        }

        public Armor FindArmorById(int id)
        {
            return this.context.Armors.Find(id);
        }

        public void UpdateArmor(Armor toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
        }

        public void DeleteArmor(int id)
        {
            var toDelete = this.context.Armors.Find(id);
            this.context.Armors.Remove(toDelete);
        }
    }
}