using App.Domain.Core.ServiceOn.Category.Data.Repository;
using App.Domain.Core.ServiceOn.Category.Dtos;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;

namespace App.Infra.Repository.Ef.ServiceOn.SubCategories
{
    public class SubCategoryRepository(ServiceOnDbContext _context) : ISubcategoryRepository
    {
        public Task<Result> Add(SubCategoryDto subCategory, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<Result> Delete(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<List<SubCategoryDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SubCategoryDto> GetById(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
