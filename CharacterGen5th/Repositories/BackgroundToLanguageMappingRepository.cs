using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class BackgroundToLanguageMappingRepository : AbstractRepository, IBackgroundToLanguageMappingRepository
    {
        public BackgroundToLanguageMappingRepository(CharGenContext context) : base(context) { }

        public IEnumerable<BackgroundToLanguageMap> GetClassToLanguages()
        {
            return this.context.BackgroundToLanguageMappings.ToList();
        }

        public void CreateBackgroundToSkill(BackgroundToLanguageMap newBackgroundToLanguage)
        {
            this.context.BackgroundToLanguageMappings.Add(newBackgroundToLanguage);
            this.context.SaveChanges();
        }

        public BackgroundToLanguageMap GetBackgroundToLanguageById(int id)
        {
            return this.context.BackgroundToLanguageMappings.Find(id);
        }

        public void UpdateBackgroundToLanguage(BackgroundToLanguageMap toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteBackgroundToLanguage(int id)
        {
            var toDelete = context.BackgroundToLanguageMappings.Find(id);
            this.context.BackgroundToLanguageMappings.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}