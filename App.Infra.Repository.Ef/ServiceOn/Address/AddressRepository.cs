using App.Domain.Core.ServiceOn.Address.Data.Repository;
using App.Domain.Core.ServiceOn.Address.Dtos;
using App.Domain.Core.ServiceOn.Resualt;

namespace App.Infra.Repository.Ef.ServiceOn.Address
{
    public class AddressRepository : IAddressRepository
    {
        public Task<Result> Add(AddressDto address, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Result> Delete(AddressDto address, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<AddressDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AddressDto> GetById(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
