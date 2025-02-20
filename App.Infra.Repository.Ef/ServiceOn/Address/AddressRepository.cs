using App.Domain.Core.ServiceOn.Address.Data.Repository;
using App.Domain.Core.ServiceOn.Address.Dtos;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repository.Ef.ServiceOn.Address
{
    public class AddressRepository(ServiceOnDbContext _context) : IAddressRepository
    {
        public async Task<Result> Add(Domain.Core.ServiceOn.Address.Entities.Address address, CancellationToken cancellationToken)
        {
            if(address is null)
                return new Result (false , "City Not found");

            await _context.AddAsync(address);
            await _context.SaveChangesAsync();

            return new Result(true, "Successful");
        }

        public async Task<Result> Delete(int id, CancellationToken cancellationToken)
        {
            var city = await _context.Address.FirstOrDefaultAsync(x => x.Id == id);
            if (city is null)
                return new Result(false, "City Not Found");

            _context.Address.Remove(city);
            await _context.SaveChangesAsync();

            return new Result(true, "Done");
        }

        public async Task<List<AddressDto>> GetAll()
        {
            return await _context.Address
                .Select(x => new AddressDto
                {
                    Id = x.Id,
                    City = x.City,

                }).ToListAsync();
        }

        public async Task<Domain.Core.ServiceOn.Address.Entities.Address> GetById(int id, CancellationToken cancellation)
        {
            return await _context.Address.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
