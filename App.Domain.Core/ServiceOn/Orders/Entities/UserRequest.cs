using App.Domain.Core.ServiceOn.Orders.Enums;
using App.Domain.Core.ServiceOn.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Orders.Entities
{
    public class UserRequest
    {

        public int RequestId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        public DateTime DueTime { get; set; }

        public StatusEnum Status { get; set; }

        public User.Entities.User Dower { get; set; }
        public int DowerId { get; set; }

        public List<User.Entities.User> ServiceProviders { get; set; }
        public int ServiceProviderId { get; set; }

        public User.Entities.User Costomer { get; set; }
        public int CostomerId { get; set; }

        public int CategoryId { get; set; }
        public Category.Entities.Category Category { get; set; }



    }
}
