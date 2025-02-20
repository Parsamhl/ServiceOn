using App.Domain.Core.ServiceOn.Orders.Data.Repository;
using App.Domain.Core.ServiceOn.Orders.Dtos;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repository.Ef.ServiceOn.CostomerRequest
{
    public class CostomerRequserRepository(ServiceOnDbContext _context) : ICostomerRequestRepository
    {
        public async Task<Result> Add(Domain.Core.ServiceOn.Orders.Entities.CostomerRequest costomerRequest, CancellationToken cancellation)
        {
            if (costomerRequest is null)
                return new Result(false, "Invalid Request");

            await _context.CostomerRequests.AddAsync(costomerRequest);
            await _context.SaveChangesAsync();

            return new Result(true, "Done");
        }

        public async Task<Result> Delete(int id, CancellationToken cancellation)
        {
            var req = await _context.CostomerRequests.FirstOrDefaultAsync(x => x.Id == id);
            if (req is null)
                return new Result(false, "Not found");

            _context.CostomerRequests.Remove(req);
            await _context.SaveChangesAsync();

            return new Result(true, "Done");

        }

        public async Task<List<CostomerRequestDto>> GetAll()
        {
            return await _context.CostomerRequests
                .Select(x => new CostomerRequestDto { 
                
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    DueTime = x.DueTime,
                    price = x.price,
                    RequestStatus = x.RequestStatus,
                    ImagePath = x.Images,

                }).ToListAsync();
        }
    }
}
