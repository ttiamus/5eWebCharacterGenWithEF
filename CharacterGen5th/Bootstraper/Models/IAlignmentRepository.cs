using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IAlignmentRepository
    {
        IEnumerable<Alignment> GetAlignments();

        void CreateAlignment(Alignment newAlignment);

        Alignment GetAlignmentById(int id);

        void UpdateAlignment(Alignment toUpdate);

        void DeleteAbilityScore(int id);
    }
}