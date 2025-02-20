using App.Domain.Core.ServiceOn.FeedBack.Dtos;
using App.Domain.Core.ServiceOn.FeedBack.Entities;
using App.Domain.Core.ServiceOn.Resualt;

namespace App.Domain.Core.ServiceOn.FeedBack.Data.Repository
{
    public interface IFeedBackRepository
    {

        public Task<Result> Add(Entities.FeedBack feddBack , CancellationToken cancellation);
        //public Task<Result> Update(int id,   , CancellationToken cancellation);
        public Task<Result> Delete(int id, CancellationToken cancellation);
        public Task<List<FeedBackDto>>? GetAll();
        public Task<Entities.FeedBack>? GetById(int id, CancellationToken cancellation);
        void ChangeStatus(int Id , int status , CancellationToken cancellation);



    }
}
