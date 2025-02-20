using App.Domain.Core.ServiceOn.Orders.Dtos;
using App.Domain.Core.ServiceOn.Orders.Entities;
using App.Domain.Core.ServiceOn.Resualt;

namespace App.Domain.Core.ServiceOn.Orders.Data.Repository
{
    public interface IExpertRequestRepository
    {
        public Task<Result> Add(ExpertRequest expertRequest , CancellationToken cancellationToken);
        public Task<Result> delete (int id, CancellationToken cancellationToken);
        public Task<List<ExpertRequestDto>> GetAll();
        public Task<ExpertRequest> GetById(int id, CancellationToken cancellation);


    }
}
