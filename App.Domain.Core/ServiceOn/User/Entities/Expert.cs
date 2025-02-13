using App.Domain.Core.ServiceOn.Category.Entities;
using App.Domain.Core.ServiceOn.FeedBack.Entities;
using App.Domain.Core.ServiceOn.Orders.Entities;


namespace App.Domain.Core.ServiceOn.User.Entities
{
    public class Expert
    {

        public int ExpertId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age  { get; set; }
        public int Balance { get; set; }
        // expert  availability
        bool IsActive { get; set; }

        public SubCategories Abilities { get; set; }
        public int AbilityId { get; set; }

        //average of score
        public float Rate { get; set; }



        // all feedbacks recived from costomers
        public List<FeedBack.Entities.FeedBack> feedBacks { get; set; }

        // all Requests sent from Costomers
        public List<CostomerRequest> CostomerRequests { get; set; }

        
        // requests sent
        public List<ExpertRequest> ExpertRequests { get; set; }

        public Address.Entities.Address Address { get; set; } // each user must have an address (city)
        public int AddressId { get; set; }

    }
}
