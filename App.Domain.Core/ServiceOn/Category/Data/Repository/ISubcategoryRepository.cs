using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Category.Data.Repository
{
    public interface ISubcategoryRepository
    {
        void Add(Entities.SubCategories subcategory);
        void Delete(Entities.SubCategories subcategory);
        List<Entities.SubCategories> GetAll();
        List<Entities.SubCategories> AllsubCategories(int id);


    }
}
