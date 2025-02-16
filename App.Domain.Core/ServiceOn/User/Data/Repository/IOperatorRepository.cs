

using App.Domain.Core.ServiceOn.Resualt;
using App.Domain.Core.ServiceOn.User.Dtos;

namespace App.Domain.Core.ServiceOn.User.Data.Repository
{
    public interface IOperatorRepository
    {
        public Task<Result> add(UserDtos user, CancellationToken cancellation);
        public Task<Result> Delete(UserDtos user, CancellationToken cancellation);
        public Task<Entities.Operator> GetById(int id, CancellationToken cancellation);
        public Task<List<UserDtos>> GetAll();



    }
}
