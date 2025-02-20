
using App.Domain.Core.ServiceOn.Address.Dtos;
using App.Domain.Core.ServiceOn.Address.Entities;
using App.Domain.Core.ServiceOn.Resualt;


namespace App.Domain.Core.ServiceOn.Address.Data.Repository
{
    public interface IAddressRepository
    {
        public Task<Result> Add(Entities.Address address , CancellationToken cancellationToken);
        public Task <Result> Delete(int id , CancellationToken cancellationToken);
        public Task<Entities.Address> GetById (int id , CancellationToken cancellation);
        public Task<List<AddressDto>> GetAll();


    }
}
