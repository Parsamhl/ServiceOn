using App.Domain.Core.ServiceOn.Category.Data.Repository;
using App.Domain.Core.ServiceOn.Category.Dtos;
using App.Domain.Core.ServiceOn.Category.Entities;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repository.Ef.ServiceOn.Category
{
    public class CategoryRepository(ServiceOnDbContext _context) : ICategoryRepository
    {
        public async Task<Result> Add(Categories category, CancellationToken cancellation)
        {
            if (category == null)
                return new Result(false, "Invalid Category");
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();

            return new Result(true, "Done");

        }

        public async Task<Result> Delete(int id, CancellationToken cancellation)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id);

            if (category is null)
                return new Result(false, "Category not found");

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return new Result(true, "Done");
        }

        public async Task<List<CategoryDto>> GetAll()
        {
            return await _context.Categories
                .Select(x => new CategoryDto
                {

                    Id = x.CategoryId,
                    CategoryName = x.CategoryName
                }).ToListAsync();
        }

        public async Task<Categories> GetById(int id, CancellationToken cancellation)
        {
            return await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id);
        }
    }
}
