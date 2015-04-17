﻿using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen5th.Unity
{
    interface IClassRepository
    {
        IEnumerable<Class> GetClasses();

        void CreateFeat(Class newSizes);

        Class FindFeatById(int id);

        void UpdateFeat(Class toUpdate);

        void DeleteFeat(int id);
    }
}