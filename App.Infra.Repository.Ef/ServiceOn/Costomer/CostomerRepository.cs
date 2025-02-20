using App.Domain.Core.ServiceOn.Resualt;
using App.Domain.Core.ServiceOn.User.Data.Repository;
using App.Domain.Core.ServiceOn.User.Dtos;
using App.Domain.Core.ServiceOn.User.Entities;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;


namespace App.Infra.Repository.Ef.ServiceOn.Costomer
{
    public class CostomerRepository(ServiceOnDbContext _context) : ICostomerRepository
    {

        public async Task<Result> add(User user, CancellationToken cancellation)
        {
            if (user is null)
                return new Result(false, "Invalid User");

            await _context.AddAsync(user);
            await _context.SaveChangesAsync();

            return new Result(true, "Done");
        }

        public async Task<float> DepositBalance(int id, float amount, CancellationToken cancellation)
        {
            var user = await _context.Costomers.FirstOrDefaultAsync(x => x.Id == id);

            user.Balance += amount;
            await _context.SaveChangesAsync();
            return user.Balance;

        }

        public async Task<List<UserDtos>>? GetAll()
        {
            return await _context.Costomers
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
            return await _context.Costomers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<float> WithrawBalance(int id, float amount, CancellationToken cancellation)
        {
            var user = await _context.Costomers.FirstOrDefaultAsync(x => x.Id == id);

            user.Balance -= amount;
            await _context.SaveChangesAsync();
            return user.Balance;
        }
    }
}
