using App.Domain.Core.ServiceOn.Orders.Dtos;
using App.Domain.Core.ServiceOn.Resualt;

namespace App.Domain.Core.ServiceOn.Orders.Data.Repository
{
    public interface ICostomerRequestRepository
    {

        public Task<Result> Add(CostomerRequestDto costomerRequestDto , CancellationToken cancellation);
        public Task <Result> Delete (CostomerRequestDto costomerRequestDto, CancellationToken cancellation);

        public Task<List<CostomerRequestDto>> GetAll();


    }
}
