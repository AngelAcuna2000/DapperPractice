﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPractice
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories();
    }
}
