using App.Domain.Core.ServiceOn.Orders.Dtos;
using App.Domain.Core.ServiceOn.Orders.Entities;
using App.Domain.Core.ServiceOn.Resualt;

namespace App.Domain.Core.ServiceOn.Orders.Data.Repository
{
    public interface ICostomerRequestRepository
    {

        public Task<Result> Add(CostomerRequest costomerRequest , CancellationToken cancellation);
        public Task <Result> Delete (int id , CancellationToken cancellation);

        public Task<List<CostomerRequestDto>> GetAll();


    }
}
