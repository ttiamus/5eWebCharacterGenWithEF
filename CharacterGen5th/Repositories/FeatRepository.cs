using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class FeatRepository : AbstractRepository, IFeatRepository
    {
        public FeatRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Feat> GetFeats()
        {
            return this.context.Feats.ToList();
        }

        public void CreateFeat(Feat newFeat)
        {
            this.context.Feats.Add(newFeat);
        }

        public Feat FindFeatById(int id)
        {
            return this.context.Feats.Find(id);
        }

        public void UpdateFeat(Feat toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
        }

        public void DeleteFeat(int id)
        {
            var toDelete = this.context.Feats.Find(id);
            this.context.Feats.Remove(toDelete);
        }
    }
}