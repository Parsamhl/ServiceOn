using App.Domain.Core.ServiceOn.Orders.Data.Repository;
using App.Domain.Core.ServiceOn.Orders.Dtos;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;

namespace App.Infra.Repository.Ef.ServiceOn.CostomerRequest
{
    public class CostomerRequserRepository(ServiceOnDbContext _context) : ICostomerRequestRepository
    {
        public Task<Result> Add(CostomerRequestDto costomerRequestDto, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<Result> Delete(CostomerRequestDto costomerRequestDto, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<List<CostomerRequestDto>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
