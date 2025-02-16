using App.Domain.Core.ServiceOn.Address.Entities;
using App.Domain.Core.ServiceOn.Base.Entities;
using App.Domain.Core.ServiceOn.Orders.Enums;
using App.Domain.Core.ServiceOn.User.Entities;

namespace App.Domain.Core.ServiceOn.Orders.Entities
{
    public class CostomerRequest
    {

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? price { get; set; }
        public DateTime? DueTime { get; set; }

        public StatusEnum RequestStatus { get; set; } = StatusEnum.Waiting;
        public Expert ChoosenExpert { get; set; } // kasi ke darkhastesh ghabol shode
        public int? ExpertId { get; set; }

        public Costomer? Costomer { get; set; }
        public int? CostomerId { get; set; }

        public List<ExpertRequest> RecivedRequest { get; set; }

        public Address.Entities.Address? RequestAdderss {  get; set; }    
        public int? AddressId{ get; set; }

        public List<Image>? Images { get; set; }

    }
}
