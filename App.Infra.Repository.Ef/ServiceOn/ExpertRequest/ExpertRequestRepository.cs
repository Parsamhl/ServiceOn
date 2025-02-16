using App.Domain.Core.ServiceOn.Orders.Data.Repository;
using App.Domain.Core.ServiceOn.Orders.Dtos;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;

namespace App.Infra.Repository.Ef.ServiceOn.ExpertRequest
{
    public class ExpertRequestRepository(ServiceOnDbContext _context) : IExpertRequestRepository
    {
        public Task<Result> Add(ExpertRequestDto expertRequest, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Result> delete(ExpertRequestDto expertRequest, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ExpertRequestDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ExpertRequestDto> GetById(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
