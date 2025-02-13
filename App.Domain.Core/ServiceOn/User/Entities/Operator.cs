using App.Domain.Core.ServiceOn.FeedBack.Entities;
using App.Domain.Core.ServiceOn.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.User.Entities
{
    public class Operator
    {
        public int OperatorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<FeedBack.Entities.FeedBack> FeedBacks { get; set; } // feedbacks to apply

        public List<CostomerRequest> CostomersRequests { get; set; }

        public List<ExpertRequest> ExpertsRequests { get; set; }
    }
}
