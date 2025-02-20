using App.Domain.Core.ServiceOn.Base.Entities;
using App.Domain.Core.ServiceOn.Orders.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ServiceOn.Orders.Dtos
{
    public class CostomerRequestDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? price { get; set; }
        public DateTime? DueTime { get; set; }
        public List<Image> ImagePath { get; set; }
        public StatusEnum RequestStatus { get; set; } = StatusEnum.Waiting;

    }
}
