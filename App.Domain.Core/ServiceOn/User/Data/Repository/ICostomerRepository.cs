

using App.Domain.Core.ServiceOn.Resualt;

namespace App.Domain.Core.ServiceOn.User.Data.Repository
{
    public interface ICostomerRepository
    {
        public Task<Result> add(Dtos.UserDtos user, CancellationToken cancellation);
        public Task<User.Entities.User>? GetById(int id, CancellationToken cancellation);
        public Task<List<User.Entities.User>>? GetAll(User.Entities.User user, CancellationToken cancellation);
        public Task<float> DepositBalance (int id , float amount);
        public Task<float>WithrawBalance (int id , float amount);   


    }
}
