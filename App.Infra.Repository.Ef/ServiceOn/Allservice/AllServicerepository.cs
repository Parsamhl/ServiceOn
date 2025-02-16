using App.Domain.Core.ServiceOn.AllService.Data.Repository.cs;
using App.Domain.Core.ServiceOn.AllService.Dtos;
using App.Domain.Core.ServiceOn.AllService.Entities;
using App.Domain.Core.ServiceOn.Resualt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Repository.Ef.ServiceOn.Allservice
{
    public class AllServicerepository : IAllServicerepository
    {
        public Task<Result> Add(AllServiceDto service, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<Result> Delete(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<List<AllServiceDto>> GetAllService()
        {
            throw new NotImplementedException();
        }

        public Task<AllServiceDto> GetServic(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
