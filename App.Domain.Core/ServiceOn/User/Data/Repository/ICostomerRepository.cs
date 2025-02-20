

using App.Domain.Core.ServiceOn.Resualt;
using App.Domain.Core.ServiceOn.User.Dtos;
using App.Domain.Core.ServiceOn.User.Entities;

namespace App.Domain.Core.ServiceOn.User.Data.Repository
{
    public interface ICostomerRepository
    {
        public Task<Result> add(Entities.User user, CancellationToken cancellation);
        public Task<Entities.User>? GetById(int id, CancellationToken cancellation);
        public Task<List<UserDtos>>? GetAll();
        public Task<float> DepositBalance (int id , float amount, CancellationToken cancellation);
        public Task<float>WithrawBalance (int id , float amount, CancellationToken cancellation);   


    }
}
