using CharacterGen5th.Models;
using CharacterGen5th.Unity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class SizeRepository : AbstractRepository, ISizeRepository
    {
        public SizeRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Size> GetSizes()
        {
            return this.context.Sizes.ToList();
        }

        public void CreateSize(Size newSize)
        {
            this.context.Sizes.Add(newSize);
        }

        public Size FindSizeById(int id)
        {
            return this.context.Sizes.Find(id);
        }

        public void UpdateSize(Skill toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
        }

        public void DeleteSize(int id)
        {
            var toDelete = this.context.Sizes.Find(id);
            this.context.Sizes.Remove(toDelete);
        }
    }
}