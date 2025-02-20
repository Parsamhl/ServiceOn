using App.Domain.Core.ServiceOn.Resualt;
using App.Domain.Core.ServiceOn.User.Data.Repository;
using App.Domain.Core.ServiceOn.User.Dtos;
using App.Domain.Core.ServiceOn.User.Entities;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repository.Ef.ServiceOn.Expert
{
    public class ExpertRepository(ServiceOnDbContext _context) : IExpertrepository
    {
        public async Task<Result> Add(Domain.Core.ServiceOn.User.Entities.Expert expert, CancellationToken cancellation)
        {
            if (expert is null)
                return new Result(false, "Invalid User");

            await _context.AddAsync(expert);
            await _context.SaveChangesAsync(cancellation);
            return new Result(true, " Done");
        }

        public async Task<Result> Delete(int id, CancellationToken cancellation)
        {
            var expert = await _context.Experts.FirstOrDefaultAsync(x => x.Id == id);

            if (expert is null)
                return new Result(false, " user not fund");

            _context.Experts.Remove(expert);
            await _context.SaveChangesAsync();
            return new Result(true, "Done");
        }

        public async Task<float> DepositBalance(int id, float amount)
        {
            var user = await _context.Experts.FirstOrDefaultAsync(x => x.Id == id);

            user.Balance += amount;
            await _context.SaveChangesAsync();
            return user.Balance;
        }

        public async Task<List<UserDtos>>? GetAll()
        {
            return await _context.Experts
                .Select(x => new UserDtos
                {
                    Age = x.Age,
                    Balance = x.Balance,
                    LastName = x.LastName,
                    Name = x.Name,
                    Password = x.Password,
                    UserName = x.UserName,
                }).ToListAsync();
        }

        public async Task<User>? GetById(int id, CancellationToken cancellation)
        {
            return await _context.Experts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<float> WithrawBalance(int id, float amount)
        {
            var user = await _context.Experts.FirstOrDefaultAsync(x => x.Id == id);

            user.Balance -= amount;
            await _context.SaveChangesAsync();
            return user.Balance;
        }
    }
}
