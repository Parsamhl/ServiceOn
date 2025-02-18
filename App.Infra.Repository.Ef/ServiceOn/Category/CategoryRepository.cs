using App.Domain.Core.ServiceOn.Category.Data.Repository;
using App.Domain.Core.ServiceOn.Category.Dtos;
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
        public Task<CategoryDto> Add(CategoryDto categoryDto, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> Delete(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetById(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
