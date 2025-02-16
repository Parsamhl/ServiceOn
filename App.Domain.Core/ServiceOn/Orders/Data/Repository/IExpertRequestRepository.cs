using App.Domain.Core.ServiceOn.Orders.Dtos;
using App.Domain.Core.ServiceOn.Resualt;

namespace App.Domain.Core.ServiceOn.Orders.Data.Repository
{
    public interface IExpertRequestRepository
    {
        public Task<Result> Add(ExpertRequestDto expertRequest , CancellationToken cancellationToken);
        public Task<Result> delete (ExpertRequestDto expertRequest, CancellationToken cancellationToken);
        public Task<List<ExpertRequestDto>> GetAll();
        public Task<ExpertRequestDto> GetById(int id, CancellationToken cancellation);


    }
}
