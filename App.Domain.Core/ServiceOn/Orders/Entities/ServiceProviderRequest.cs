using App.Domain.Core.ServiceOn.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Orders.Entities
{
    public class ServiceProviderRequest
    {
        public int ServiceId { get; set; }
        public int ServiceProviderId { get; set; }
        // public User.Entities.User ServiceProvider { get; set; }
        public string Price { get; set; }
        public DateTime DueTime { get; set; }
        public List<UserRequest> UserRequests { get; set; }

        public User.Entities.User Costomer { get; set; }

        public int CostomerId { get; set; }

    }
}
