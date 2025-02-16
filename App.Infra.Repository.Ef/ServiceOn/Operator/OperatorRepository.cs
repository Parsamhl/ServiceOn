using App.Domain.Core.ServiceOn.Resualt;
using App.Domain.Core.ServiceOn.User.Data.Repository;
using App.Domain.Core.ServiceOn.User.Dtos;

namespace App.Infra.Repository.Ef.ServiceOn.Operator
{
    public class OperatorRepository : IOperatorRepository
    {
        public Task<Result> add(UserDtos user, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<Result> Delete(UserDtos user, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDtos>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Core.ServiceOn.User.Entities.Operator> GetById(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
