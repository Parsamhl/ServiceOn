using App.Domain.Core.ServiceOn.FeedBack.Dtos;

using App.Domain.Core.ServiceOn.Resualt;

namespace App.Domain.Core.ServiceOn.FeedBack.Data.Repository
{
    public interface IFeedBackRepository
    {

        public Task<Result> Add(FeedBackDto feddBack , CancellationToken cancellation);
        //public Task<Result> Update(int id,   , CancellationToken cancellation);
        public Task<Result> Delete(int id, CancellationToken cancellation);
        public Task<List<FeedBackDto>>? GetAll(FeedBackDto feddBack, CancellationToken cancellation);
        public Task<FeedBackDto>? GetById(int id, CancellationToken cancellation);
        void ChangeStatus(Entities.FeedBack feedback);



    }
}
