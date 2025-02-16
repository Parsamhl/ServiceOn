using App.Domain.Core.ServiceOn.FeedBack.Data.Repository;
using App.Infra.Db.SqlServer.SqlServerDb;

namespace App.Infra.Repository.Ef.ServiceOn.FeedBack
{
    public class FeedBackRepository(ServiceOnDbContext _context) : IFeedBackRepository
    {
        public void Add(Domain.Core.ServiceOn.FeedBack.Entities.FeedBack feedback)
        {
            
        }

        public void ChangeStatus(Domain.Core.ServiceOn.FeedBack.Entities.FeedBack feedback)
        {
            
        }

        public void Delete(Domain.Core.ServiceOn.FeedBack.Entities.FeedBack feedback)
        {
            
        }

        public List<Domain.Core.ServiceOn.FeedBack.Entities.FeedBack> GetAll()
        {
            return null;
        }

        public Domain.Core.ServiceOn.FeedBack.Entities.FeedBack GetFeedBack(int id)
        {
            return null;
        }

        public List<Domain.Core.ServiceOn.FeedBack.Entities.FeedBack> GetFor(int id)
        {
            return null ;
        }
    }
}
