

using App.Domain.Core.ServiceOn.Orders.Entities;

namespace App.Domain.Core.ServiceOn.Address.Entities
{
    public class Address
    {

        public int Id { get; set; }

        public string City { get; set; }

        public List <User.Entities.Costomer> Costomer { get; set; }
        public string CostomerId { get; set; }
        public List <User.Entities.Expert> Expert { get; set; }

        public List<CostomerRequest> costomerRequests { get; set; }

        public List<ExpertRequest > expertRequests { get; set; }
    }
}
