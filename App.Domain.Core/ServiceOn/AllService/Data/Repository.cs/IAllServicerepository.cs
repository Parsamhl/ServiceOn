using App.Domain.Core.ServiceOn.AllService.Entities;

namespace App.Domain.Core.ServiceOn.AllService.Data.Repository.cs
{
    public interface IAllServicerepository
    {
        List<Entities.AllService> GetAllService();
        Entities.AllService GetService(int id);
        void Add(Entities.AllService service);
        void Delete(Entities.AllService service);

    }
}
