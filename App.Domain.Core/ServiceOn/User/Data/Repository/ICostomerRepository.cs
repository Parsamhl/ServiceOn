

namespace App.Domain.Core.ServiceOn.User.Data.Repository
{
    public interface ICostomerRepository
    {
        void Add(Entities.Costomer costomer);
        Entities.Costomer GetCostomer(int id);
        List<Entities.Costomer> GetAll();
        float DepositBalance (int id , float amount);
        float WithrawBalance (int id , float amount);   


    }
}
