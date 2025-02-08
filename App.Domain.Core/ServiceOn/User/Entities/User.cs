using App.Domain.Core.ServiceOn.Wallet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int Role { get; set; }  // => 1 = Costomer , 2 = ServiceProvider , 3 = Admin


        public int WalletId { get; set; }
        public Wallet.Entities.Wallet Wallet { get; set; }

      
        public int ServiceVategoryId { get; set; }
        public List<Category.Entities.ServicesCategory> Services { get; set; }
    }
}
