using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Wallet.Entities
{
    public class Wallet
    {
        public int WalletId { get; set; }
        public int Amount { get; set; }

        public int UserId { get; set; }
        public User.Entities.User User { get; set; }



    }
}
