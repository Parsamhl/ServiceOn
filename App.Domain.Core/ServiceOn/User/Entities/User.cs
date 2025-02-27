

using Microsoft.AspNetCore.Identity;

namespace App.Domain.Core.ServiceOn.User.Entities
{
    public class User : IdentityUser<int>
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public int? CityId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public float Balance { get; set; } = 0;
        public string PhoneNumber {  get; set; }

        public DateTime RegisterdAt { get; set; }
    }
}
