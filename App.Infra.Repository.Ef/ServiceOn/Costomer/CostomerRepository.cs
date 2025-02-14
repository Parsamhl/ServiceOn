using App.Domain.Core.ServiceOn.User.Data.Repository;
using App.Infra.Db.SqlServer.SqlServerDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Repository.Ef.ServiceOn.Costomer
{
    public class CostomerRepository : ICostomerRepository
    {

        private readonly ServiceOnDbContext _context;

        public CostomerRepository()
        {
            _context = new ServiceOnDbContext();
        }
        public void Add(Domain.Core.ServiceOn.User.Entities.Costomer costomer)
        {
            _context.Add(costomer);
            _context.SaveChanges();
        }

        public float DepositBalance(int id, float amount)
        {
            var Costomer = _context.Costomers.FirstOrDefault(x => x.CostomerId == id);
            if (Costomer == null)
            {
                throw new Exception("User Not Found");
            }
            else
            {
                Costomer.Balance += Convert.ToInt32(amount);
                _context.SaveChanges();
                return Costomer.Balance;

            }
        }

        public List<Domain.Core.ServiceOn.User.Entities.Costomer> GetAll()
        
            => _context.Costomers.ToList();


        public Domain.Core.ServiceOn.User.Entities.Costomer GetCostomer(int id)

            => _context.Costomers.FirstOrDefault(x => x.CostomerId == id);
        

        public float WithrawBalance(int id, float amount)
        {
            var Costomer = _context.Costomers.FirstOrDefault(x => x.CostomerId == id);
            if (Costomer == null)
            {
                throw new Exception("User Not Found");
            }
            else
            {
                Costomer.Balance -= Convert.ToInt32(amount);
                _context.SaveChanges();
                return Costomer.Balance;

            }
        }
    }
}
