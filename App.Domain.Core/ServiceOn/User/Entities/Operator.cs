using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.User.Entities
{
    public class Operator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int Role {  get; set; }  // => 1 = Costomer , 2 = ServiceProvider , 3 = Admin

    }
}
