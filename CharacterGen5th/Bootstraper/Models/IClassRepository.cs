using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface IClassRepository
    {
        IEnumerable<Class> GetClasses();

        void CreateClass(Class newClass);

        Class FindClassById(int id);

        void UpdateClass(Class toUpdate);

        void DeleteClass(int id);
    }
}
