using App.Domain.Core.ServiceOn.Resualt;
using App.Domain.Core.ServiceOn.User.Data.Repository;
using App.Domain.Core.ServiceOn.User.Dtos;
using App.Domain.Core.ServiceOn.User.Entities;
using App.Infra.Db.SqlServer.SqlServerDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Repository.Ef.ServiceOn.Costomer
{
    public class CostomerRepository(ServiceOnDbContext _context) : ICostomerRepository
    {

        private readonly ServiceOnDbContext _context;


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
