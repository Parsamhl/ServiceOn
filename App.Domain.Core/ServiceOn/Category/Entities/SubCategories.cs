using App.Domain.Core.ServiceOn.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Category.Entities
{
    public  class SubCategories
    {

        public int SubCategoryId { get; set; }   
        public  string SubCategoryName { get; set; }
        public List<Expert> experts { get; set; }
        public Categories Categories { get; set; }
        public int CategoryId { get; set; } 
        
    }
}
