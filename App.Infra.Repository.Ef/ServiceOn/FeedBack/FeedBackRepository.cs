using App.Domain.Core.ServiceOn.FeedBack.Data.Repository;
using App.Domain.Core.ServiceOn.FeedBack.Dtos;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repository.Ef.ServiceOn.FeedBack
{
    public class FeedBackRepository(ServiceOnDbContext _context) : IFeedBackRepository
    {
        public async Task<Result> Add(Domain.Core.ServiceOn.FeedBack.Entities.FeedBack feddBack, CancellationToken cancellation)
        {
            if (feddBack is null) 
            return new Result(false, "invalid");
            
            await _context.FeedBacks.AddAsync(feddBack); 
            await _context.SaveChangesAsync();

            return new Result(true , "Done");

        }

        public void ChangeStatus(int Id, int status , CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public async Task<Result> Delete(int id, CancellationToken cancellation)
        {
            var feedback = await _context.FeedBacks.FirstOrDefaultAsync(x => x.FeedBackId == id);
            if (feedback is null)
                return new Result(false, "Invalid");

            _context.FeedBacks.Remove(feedback);    
            await _context.SaveChangesAsync();
            return new Result(true, " Done");
        }

        public async Task<List<FeedBackDto>>? GetAll()
        {
            return await _context.FeedBacks
                .Select(x=> new FeedBackDto { 
                
                    Description = x.Description,
                    ExpertID = x.Expert.Id,
                    FeedBackStatus = x.FeedBackStatus,
                    Rate = x.Rate,
                    SubmitedAt = x.SubmitedAt,
                    FeedBackId = x.FeedBackId,
                    Title = x.Title,

                }).ToListAsync();
        }

        public async Task<Domain.Core.ServiceOn.FeedBack.Entities.FeedBack>? GetById(int id, CancellationToken cancellation)
        {
            return await _context.FeedBacks.FirstOrDefaultAsync(x => x.FeedBackId == id);
        }
    }
}
