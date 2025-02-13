using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.FeedBack.Data.Repository
{
    public interface IFeedBackRepository
    {

        void Add(Entities.FeedBack feedback);
        void Delete(Entities.FeedBack feedback);
        List<Entities.FeedBack> GetAll();
        List<Entities.FeedBack> GetFor(int id);
        Entities.FeedBack GetFeedBack(int id);
        void ChangeStatus(Entities.FeedBack feedback);



    }
}
