using App.Domain.Core.ServiceOn.Category.Dtos;
using App.Domain.Core.ServiceOn.Category.Entities;
using App.Domain.Core.ServiceOn.Resualt;


namespace App.Domain.Core.ServiceOn.Category.Data.Repository
{
    public interface ISubcategoryRepository
    {
        public Task<Result> Add(SubCategories subCategory , CancellationToken cancellation);
        public Task<Result> Delete(int id, CancellationToken cancellation);
        public Task<List<SubCategoryDto>> GetAll();
        public Task<SubCategoryDto> GetById(int id, CancellationToken cancellation);


    }
}
