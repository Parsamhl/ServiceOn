using App.Domain.Core.ServiceOn.Orders.Data.Repository;


namespace App.Infra.Repository.Ef.ServiceOn.CostomerRequest
{
    public class CostomerRequserRepository : ICostomerRequestRepository
    {
        public void Add(Domain.Core.ServiceOn.Orders.Entities.CostomerRequest costomerRequest)
        {
           return;
        }

        public void Delete(Domain.Core.ServiceOn.Orders.Entities.CostomerRequest costomerRequest)
        {
            return ;
        }

        public List<Domain.Core.ServiceOn.Orders.Entities.CostomerRequest> GetAll()
        {
            return null;
        }
    }
}
