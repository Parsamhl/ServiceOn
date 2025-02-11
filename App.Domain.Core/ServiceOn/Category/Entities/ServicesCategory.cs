using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Category.Entities
{
    public class ServicesCategory
    {

        public int ServiceCategoryId { get; set; }
        public string Name { get; set; }

        public Category Category { get; set; }

        public List<User.Entities.User> Providers { get; set; }


    }
}
