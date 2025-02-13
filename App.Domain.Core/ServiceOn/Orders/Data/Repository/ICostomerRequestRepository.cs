namespace App.Domain.Core.ServiceOn.Orders.Data.Repository
{
    public interface ICostomerRequestRepository
    {

        void Add(Entities.CostomerRequest costomerRequest);
        void Delete(Entities.CostomerRequest costomerRequest);
        List<Entities.CostomerRequest> GetAll();


    }
}
