using App.Domain.Core.ServiceOn.Category.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Repository.Ef.ServiceOn.SubCategories
{
    public class SubCategoryRepository : ISubcategoryRepository
    {
        public void Add(Domain.Core.ServiceOn.Category.Entities.SubCategories subcategory)
        {
          
        }

        public List<Domain.Core.ServiceOn.Category.Entities.SubCategories> AllsubCategories(int id)
        {
            return null;
        }

        public void Delete(Domain.Core.ServiceOn.Category.Entities.SubCategories subcategory)
        {
          
        }

        public List<Domain.Core.ServiceOn.Category.Entities.SubCategories> GetAll()
        {
            return null;
        }
    }
}
