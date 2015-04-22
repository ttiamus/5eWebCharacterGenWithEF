using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IClassToSpellMappingRepository
    {
        IEnumerable<ClassToSpellMap> GetClassToSpells();

        void CreateClassToSpell(ClassToSpellMap newClassToSpell);

        ClassToSpellMap GetClassToSpellById(int id);

        void UpdateClassToSpell(ClassToSpellMap toUpdate);

        void DeleteClassToSpell(int id);
    }
}