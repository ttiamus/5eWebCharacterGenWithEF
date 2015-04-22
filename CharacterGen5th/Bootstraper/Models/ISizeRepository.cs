using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Bootstraper.Models
{
    public interface ISizeRepository
    {
        IEnumerable<Size> GetSizes();

        void CreateSize(Size newSize);

        Size FindSizeById(int id);

        void UpdateSize(Skill toUpdate);

        void DeleteSize(int id);
    }
}