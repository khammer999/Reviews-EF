﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
     public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category FindOneCategoryById(int id);



    }
}
