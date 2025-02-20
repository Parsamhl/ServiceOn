using App.Domain.Core.ServiceOn.Category.Data.Repository;
using App.Domain.Core.ServiceOn.Category.Dtos;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repository.Ef.ServiceOn.SubCategories
{
    public class SubCategoryRepository(ServiceOnDbContext _context) : ISubcategoryRepository
    {
        public async Task<Result> Add(Domain.Core.ServiceOn.Category.Entities.SubCategories subCategory, CancellationToken cancellation)
        {
            if (subCategory is null)
                return new Result(false, "Invalid");

            await _context.SubCategories.AddAsync(subCategory);
            await _context.SaveChangesAsync();

            return new Result(true, "Done");
        }

        public async Task<Result> Delete(int id, CancellationToken cancellation)
        {
            var subCat = await _context.SubCategories.FirstOrDefaultAsync(x => x.SubCategoryId == id);

            if (subCat is null)
                return new Result(false, "NotFound ");

            _context.SubCategories.Remove(subCat);
            await _context.SaveChangesAsync();

            return new Result(true, " Done");
        }

        public async Task<List<SubCategoryDto>> GetAll()
        {
            return await _context.SubCategories
                .Select(x => new SubCategoryDto
                {
                    SubCategoryId = x.SubCategoryId,
                    SubCategoryName = x.SubCategoryName

                }).ToListAsync();
        }

        public async Task<SubCategoryDto> GetById(int id, CancellationToken cancellation)
        {

            return null;
        }
    }
}
