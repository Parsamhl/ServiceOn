using App.Domain.Core.ServiceOn.FeedBack.Enums;
using App.Domain.Core.ServiceOn.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.FeedBack.Entities
{
    public class FeedBack
    {
        public int FeedBackId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; } 
        public StatusEnum? FeedBackStatus { get; set; } = StatusEnum.waiting;
        
        public DateOnly SubmitedAt { get; set; }

        public float? Rate { get; set; }
        // expert whoe rated by this 
        public Expert? Expert { get; set; }
        public int? ExpertId { get; set; }
        // costomer who filled this rating form
        public Costomer? Costomer { get; set; }
        public int? CostomerId { get; set; } 

    }
}
