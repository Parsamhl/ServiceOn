using App.Domain.Core.ServiceOn.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Orders.Entities
{
    public class ExpertRequest
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
        public DateTime DueTime { get; set; }

        public Expert Expert { get; set; }
        public int ExpertId { get; set; }

        public Address.Entities.Address RequestAdderss { get; set; }
        public int AddressId { get; set; }


    }
}
