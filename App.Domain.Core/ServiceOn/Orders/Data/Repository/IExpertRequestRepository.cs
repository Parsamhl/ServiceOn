namespace App.Domain.Core.ServiceOn.Orders.Data.Repository
{
    public interface IExpertRequestRepository
    {
        void Add(Entities.ExpertRequest expertRequest);
        void Delete(Entities.ExpertRequest expertRequest);
        List<Entities.ExpertRequest> GetAll();
        List<Entities.ExpertRequest> GetFor(int id);


    }
}
