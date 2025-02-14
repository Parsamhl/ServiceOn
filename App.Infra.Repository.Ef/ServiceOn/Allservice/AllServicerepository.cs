using App.Domain.Core.ServiceOn.AllService.Data.Repository.cs;
using App.Domain.Core.ServiceOn.AllService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Repository.Ef.ServiceOn.Allservice
{
    public class AllServicerepository : IAllServicerepository
    {
        public void Add(AllService service)
        {
            
        }

        public void Delete(AllService service)
        {
        }

        public List<AllService> GetAllService()
        {
            return null;
        }

        public AllService GetService(int id)
        {
            return null;
        }
    }
}
