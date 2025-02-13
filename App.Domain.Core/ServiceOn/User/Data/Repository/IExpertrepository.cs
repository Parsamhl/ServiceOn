using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.User.Data.Repository
{
    public interface IExpertrepository
    {
        void Add(Entities.Expert entity);
        Entities.Expert GetExpert(int id);
        List<Entities.Expert> GetAll();
        float DepositBalance(int id, float amount);
        float WithrawBalance(int id, float amount);

    }
}
