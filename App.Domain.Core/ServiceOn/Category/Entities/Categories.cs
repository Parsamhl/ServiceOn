using App.Domain.Core.ServiceOn.AllService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Category.Entities
{
    public class Categories
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // daste bandi khedmati ke category zir majmoe an ast
        public AllService.Entities.AllService AllService { get; set; }
        public int MainSerivceId { get; set; }


        // zir majmoe haye har ye k az category ha 
        public List<SubCategories> SubCategories { get; set; }
        
    }
}
