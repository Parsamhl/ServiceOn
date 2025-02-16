using App.Domain.Core.ServiceOn.AllService.Dtos;
using App.Domain.Core.ServiceOn.AllService.Entities;
using App.Domain.Core.ServiceOn.Resualt;

namespace App.Domain.Core.ServiceOn.AllService.Data.Repository.cs
{
    public interface IAllServicerepository
    {
        public Task<List<AllServiceDto>> GetAllService();
        public Task<AllServiceDto> GetServic(int id , CancellationToken cancellation);
        public Task<Result> Add(AllServiceDto service , CancellationToken cancellation);
        public Task<Result> Delete(int id, CancellationToken cancellation);

    }
}
