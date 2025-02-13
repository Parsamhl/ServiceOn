using App.Domain.Core.ServiceOn.FeedBack.Entities;
using App.Domain.Core.ServiceOn.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.User.Entities
{
    public class Costomer
    {

        public int CostomerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Balance { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        // all requests that a user sent
        public List<CostomerRequest> requests { get; set; }

        public List<FeedBack.Entities.FeedBack> feedBacks { get; set; }

        public Address.Entities.Address Address { get; set; }   
        public int AddressId { get; set; }
    }
}
