using App.Domain.Core.ServiceOn.Category.Entities;

namespace App.Domain.Core.ServiceOn.AllService.Entities
{
    public class AllService
    {
        public int Id { get; set; } 

        public string Title { get; set; }

        public List<Categories> Categories { get; set; }




    }
}
