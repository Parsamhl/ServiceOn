using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Category.Data.Repository
{
    public interface ICategoryRepository
    {
        List<Entities.Categories> GetAll();
        Entities.Categories GetCategory(int id);
        void Add(Entities.Categories category);
        void Delete (Entities.Categories category);
    }
}
