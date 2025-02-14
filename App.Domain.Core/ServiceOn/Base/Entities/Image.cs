using App.Domain.Core.ServiceOn.Orders.Entities;
using App.Domain.Core.ServiceOn.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Base.Entities
{
    public class Image
    {
        #region Properties
        public int Id { get; set; }
        public string Path { get; set; }
        public int RequestId { get; set; }
        #endregion

        public CostomerRequest CostomerRequest { get; set; }
    }
}
