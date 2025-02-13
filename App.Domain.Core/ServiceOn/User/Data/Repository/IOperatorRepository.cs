

namespace App.Domain.Core.ServiceOn.User.Data.Repository
{
    public interface IOperatorRepository
    {
        void Add(Entities.Operator entity);
        Entities.Operator GetById(int id);
        List<Entities.Operator> GetAll();



    }
}
