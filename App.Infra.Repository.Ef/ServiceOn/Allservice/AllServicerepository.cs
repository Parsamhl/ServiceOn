﻿using App.Domain.Core.ServiceOn.AllService.Data.Repository.cs;
using App.Domain.Core.ServiceOn.AllService.Dtos;
using App.Domain.Core.ServiceOn.AllService.Entities;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;


namespace App.Infra.Repository.Ef.ServiceOn.Allservice
{
    public class AllServicerepository(ServiceOnDbContext _context) : IAllServicerepository
    {
        public async Task<Result> Add(AllService service, CancellationToken cancellation)
        {
            if (service is null)
                return new Result(false, "Failed to add");

            await _context.AllService.AddAsync(service);
            await _context.SaveChangesAsync();

            return new Result(true, " Successful");

        }

        public async Task<Result> Delete(int id, CancellationToken cancellation)
        {
            var service = await _context.AllService.FirstOrDefaultAsync(x => x.Id == id);

            if (service is null)
                return new Result(false, "Service not founmd");

            _context.AllService.Remove(service);
            await _context.SaveChangesAsync();

            return new Result(true, " successful");
        }

        public async Task<List<AllServiceDto>> GetAllService()
        {
            return await _context.AllService
                .Select(x => new AllServiceDto
                {
                    Id = x.Id,
                    Title = x.Title,
                }).ToListAsync();
        }

        public async Task<AllService> GetServic(int id, CancellationToken cancellation)
        {
            return await _context.AllService.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
