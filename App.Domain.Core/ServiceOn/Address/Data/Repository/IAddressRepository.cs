using App.Domain.Core.ServiceOn.Address.Dtos;
using App.Domain.Core.ServiceOn.Address.Entities;
using App.Domain.Core.ServiceOn.Resualt;


namespace App.Domain.Core.ServiceOn.Address.Data.Repository
{
    public interface IAddressRepository
    {
        public Task<Result> Add(AddressDto address , CancellationToken cancellationToken);
        public Task <Result> Delete(AddressDto address , CancellationToken cancellationToken);
        public Task<AddressDto> GetById (int id , CancellationToken cancellation);
        public Task<List<AddressDto>> GetAll();


    }
}
