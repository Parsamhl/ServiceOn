﻿using App.Domain.Core.ServiceOn.Category.Data.Repository;
using App.Domain.Core.ServiceOn.Category.Entities;
using App.Infra.Db.SqlServer.SqlServerDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Repository.Ef.ServiceOn.Category
{
    public class CategoryRepository(ServiceOnDbContext _context) : ICategoryRepository
    {
        public void Add(Categories category)
        {
            
        }

        public void Delete(Categories category)
        {
        
        }

        public List<Categories> GetAll()
        {
            return null;
        }

        public Categories GetCategory(int id)
        {
            return null;
        }
    }
}
