using App.Domain.Core.ServiceOn.Resualt;
using App.Domain.Core.ServiceOn.User.Data.Repository;
using App.Domain.Core.ServiceOn.User.Dtos;
using App.Domain.Core.ServiceOn.User.Entities;
using App.Infra.Db.SqlServer.SqlServerDb;

namespace App.Infra.Repository.Ef.ServiceOn.Expert
{
    public class ExpertRepository : IExpertrepository
    {

        private readonly ServiceOnDbContext _context;

        public ExpertRepository()
        {
            _context = new ServiceOnDbContext();
        }

        public Task<Result> add(UserDtos user, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<float> DepositBalance(int id, float amount)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>>? GetAll(User user, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<User>? GetById(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<float> WithrawBalance(int id, float amount)
        {
            throw new NotImplementedException();
        }
    }
}
