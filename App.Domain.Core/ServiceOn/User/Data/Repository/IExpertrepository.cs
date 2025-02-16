using App.Domain.Core.ServiceOn.Resualt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.User.Data.Repository
{
    public interface IExpertrepository
    {
        public Task<Result> add(Dtos.UserDtos user, CancellationToken cancellation);
        public Task<Entities.User>? GetById(int id, CancellationToken cancellation);
        public Task<List<Entities.User>>? GetAll(Entities.User user, CancellationToken cancellation);
        public Task<float> DepositBalance(int id, float amount);
        public Task<float> WithrawBalance(int id, float amount);

    }
}
