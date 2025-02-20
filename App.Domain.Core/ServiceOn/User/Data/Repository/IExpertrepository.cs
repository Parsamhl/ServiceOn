using App.Domain.Core.ServiceOn.Resualt;
using App.Domain.Core.ServiceOn.User.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.User.Data.Repository
{
    public interface IExpertrepository
    {
        public Task<Result> Add(Entities.Expert expert, CancellationToken cancellation);
        public Task<Result> Delete(int id, CancellationToken cancellation);
        public Task<Entities.User>? GetById(int id, CancellationToken cancellation);
        public Task<List<UserDtos>>? GetAll();
        public Task<float> DepositBalance(int id, float amount);
        public Task<float> WithrawBalance(int id, float amount);

    }
}
