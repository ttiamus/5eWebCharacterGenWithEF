using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class RaceToLanguageMappingRepository : AbstractRepository, IRaceToLanguageMappingRepository
    {
        public RaceToLanguageMappingRepository(CharGenContext context) : base(context) { }

        public IEnumerable<RaceToLanguagesMap> GetRaceToRaceProperties()
        {
            return this.context.RaceToLanguagesMappings.ToList();
        }

        public void CreateRaceToLanguage(RaceToLanguagesMap newRaceToLanguage)
        {
            this.context.RaceToLanguagesMappings.Add(newRaceToLanguage);
            this.context.SaveChanges();
        }

        public RaceToLanguagesMap GetRaceToLanguageById(int id)
        {
            return this.context.RaceToLanguagesMappings.Find(id);
        }

        public void UpdateRaceToLanguage(RaceToLanguagesMap toUpdate)
        {   
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteRaceToLanguage(int id)
        {
            var toDelete = context.RaceToLanguagesMappings.Find(id);
            this.context.RaceToLanguagesMappings.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}