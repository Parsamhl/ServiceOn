using App.Domain.Core.ServiceOn.Address.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Address.Data.Repository
{
    public interface IAddressRepository
    {
        void Add(Entities.Address address);
        void Delete(Entities.Address address);

    }
}
