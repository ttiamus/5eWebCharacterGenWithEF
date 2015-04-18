using CharacterGen5th.Bootstraper;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class AlignmentRepository : AbstractRepository, IAlignmentRepository
    {
        public AlignmentRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Alignment> GetAlignments()
        {
            return this.context.Alignments.ToList();
        }

        public void CreateCharacter(Alignment newAlignment)
        {
            this.context.Alignments.Add(newAlignment);
        }

        public Alignment GetAbiltyScoreById(int id)
        {
            return this.context.Alignments.Find(id);
        }

        public void Update(Alignment toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
        }

        public void DeleteAbilityScore(int id)
        {
            var toDelete = context.Alignments.Find(id);
            this.context.Alignments.Remove(toDelete);
        }
    }
}