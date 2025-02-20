using App.Domain.Core.ServiceOn.Orders.Data.Repository;
using App.Domain.Core.ServiceOn.Orders.Dtos;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repository.Ef.ServiceOn.ExpertRequest
{
    public class ExpertRequestRepository(ServiceOnDbContext _context) : IExpertRequestRepository
    {
        public async Task<Result> Add(Domain.Core.ServiceOn.Orders.Entities.ExpertRequest expertRequest, CancellationToken cancellationToken)
        {
            if (expertRequest is null)
                return new Result(false, "Invalid Request");

            await _context.ExpertRequest.AddAsync(expertRequest);
            await _context.SaveChangesAsync();

            return new Result(true, "Done");

        }

        public async Task<Result> delete(int id, CancellationToken cancellationToken)
        {
            var req = await _context.ExpertRequest.FirstOrDefaultAsync(x => x.Id == id);
            if (req is null)
                return new Result(false, "invalid");

            _context.ExpertRequest.Remove(req);
            await _context.SaveChangesAsync();
            return new Result(true, " Done");
        }

        public async Task<List<ExpertRequestDto>> GetAll()
        {
            return await _context.ExpertRequest
                .Select(x => new ExpertRequestDto
                {

                    Description = x.Description,
                    DueTime = x.DueTime,
                    Id = x.Id,
                    price = x.price,
                    Title = x.Title,

                }).ToListAsync();
        }

        public async Task<Domain.Core.ServiceOn.Orders.Entities.ExpertRequest> GetById(int id, CancellationToken cancellation)
        {
            return await _context.ExpertRequest.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
