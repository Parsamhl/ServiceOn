

using App.Domain.Core.ServiceOn.Resualt;
using App.Domain.Core.ServiceOn.User.Dtos;
using App.Domain.Core.ServiceOn.User.Entities;

namespace App.Domain.Core.ServiceOn.User.Data.Repository
{
    public interface IOperatorRepository
    {
        public Task<Result> add(Operator opt, CancellationToken cancellation);
        public Task<Result> Delete(int id, CancellationToken cancellation);
        public Task<Operator> GetById(int id, CancellationToken cancellation);
        public Task<List<OperatorDto>> GetAll();



    }
}
