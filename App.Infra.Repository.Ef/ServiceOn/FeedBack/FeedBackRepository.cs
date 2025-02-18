using App.Domain.Core.ServiceOn.FeedBack.Data.Repository;
using App.Domain.Core.ServiceOn.FeedBack.Dtos;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;

namespace App.Infra.Repository.Ef.ServiceOn.FeedBack
{
    public class FeedBackRepository(ServiceOnDbContext _context) : IFeedBackRepository
    {
        public Task<Result> Add(FeedBackDto feddBack, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public void ChangeStatus(Domain.Core.ServiceOn.FeedBack.Entities.FeedBack feedback)
        {
            throw new NotImplementedException();
        }

        public Task<Result> Delete(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<List<FeedBackDto>>? GetAll(FeedBackDto feddBack, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<FeedBackDto>? GetById(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
