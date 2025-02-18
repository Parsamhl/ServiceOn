using App.Domain.Core.ServiceOn.Category.Dtos;
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
        public Task<CategoryDto> GetById(int id , CancellationToken cancellation);
        public Task<CategoryDto> Add(CategoryDto categoryDto , CancellationToken cancellation);
        public Task<CategoryDto> Delete(int id , CancellationToken cancellation);
    }
}
