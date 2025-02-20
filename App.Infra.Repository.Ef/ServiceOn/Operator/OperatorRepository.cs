using App.Domain.Core.ServiceOn.Resualt;
using App.Domain.Core.ServiceOn.User.Data.Repository;
using App.Domain.Core.ServiceOn.User.Dtos;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repository.Ef.ServiceOn.Operator
{
    public class OperatorRepository(ServiceOnDbContext _context) : IOperatorRepository
    {
        public async Task<Result> add(Domain.Core.ServiceOn.User.Entities.Operator opt, CancellationToken cancellation)
        {
            if (opt is null)
                return new Result(false, " invalid");

            await _context.Operators.AddAsync(opt);
            await _context.SaveChangesAsync();

            return new Result(true, "Done");

        }

        public async Task<Result> Delete(int id, CancellationToken cancellation)
        {
            var opt = await _context.Operators.FirstOrDefaultAsync(x => x.OperatorId == id);
            if (opt is null)
                return new Result(false, "Operator Not found");

            _context.Operators.Remove(opt);
            await _context.SaveChangesAsync();
            return new Result(true, "Done");
        }

        public async Task<List<OperatorDto>> GetAll()
        {
            return await _context.Operators
                .Select(x => new OperatorDto
                {
                    OperatorId = x.OperatorId,
                    LastName = x.LastName,
                    Name = x.Name,
                    UserName = x.UserName


                }).ToListAsync();
        }

        public async Task<Domain.Core.ServiceOn.User.Entities.Operator> GetById(int id, CancellationToken cancellation)
        {
            return await _context.Operators.AsNoTracking().FirstOrDefaultAsync(x => x.OperatorId == id);
        }
    }
}
