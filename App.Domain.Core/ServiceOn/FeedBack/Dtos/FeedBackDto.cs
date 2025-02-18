
using App.Domain.Core.ServiceOn.FeedBack.Enums;

namespace App.Domain.Core.ServiceOn.FeedBack.Dtos
{
    public class FeedBackDto
    {
        public int FeedBackId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateOnly SubmitedAt { get; set; }
        public StatusEnum? FeedBackStatus { get; set; } = StatusEnum.waiting;
        public float? Rate { get; set; }
        public int ExpertID { get; set; }
    }
}
