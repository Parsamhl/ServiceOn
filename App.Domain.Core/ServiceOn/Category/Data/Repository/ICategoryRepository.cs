using App.Domain.Core.ServiceOn.Category.Dtos;
using App.Domain.Core.ServiceOn.Category.Entities;
using App.Domain.Core.ServiceOn.Resualt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Category.Data.Repository
{
    public interface ICategoryRepository
    {

        public Task<List<CategoryDto>> GetAll();
        public Task<Categories> GetById(int id , CancellationToken cancellation);
        public Task<Result> Add(Categories category , CancellationToken cancellation);
        public Task<Result> Delete(int id , CancellationToken cancellation);
    }
}
