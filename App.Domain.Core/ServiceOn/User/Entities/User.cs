

namespace App.Domain.Core.ServiceOn.User.Entities
{
    public class User 
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
    }
}
