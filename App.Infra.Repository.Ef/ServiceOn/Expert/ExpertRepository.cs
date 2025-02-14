using App.Domain.Core.ServiceOn.User.Data.Repository;
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
        public void Add(Domain.Core.ServiceOn.User.Entities.Expert entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public float DepositBalance(int id, float amount)
        {
            var expert = _context.Experts.FirstOrDefault(x => x.Id == id);
            if (expert == null)
            {

                throw new Exception("User Not Found ");
            }
            else
            {
                expert.Balance += Convert.ToInt32(amount);
                _context.SaveChanges();
                return expert.Balance;
            }
        }

        public List<Domain.Core.ServiceOn.User.Entities.Expert> GetAll()
        => _context.Experts.ToList();

        public Domain.Core.ServiceOn.User.Entities.Expert GetExpert(int id)

            => _context.Experts.FirstOrDefault(x => x.Id == id);
            
        

        public float WithrawBalance(int id, float amount)
        {
            var expert = _context.Experts.FirstOrDefault(x => x.Id == id);
            if (expert == null)
            {

                throw new Exception("User Not Found ");
            }
            else
            {
                expert.Balance -= Convert.ToInt32(amount);
                _context.SaveChanges();
                return expert.Balance;
            }
        }
    }
}
