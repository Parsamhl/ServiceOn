using App.Domain.Core.ServiceOn.Base.Entities;
using App.Domain.Core.ServiceOn.Resualt;


namespace App.Domain.Core.ServiceOn.Base.Data
{
    public interface IImageRepository
    {
        public Task<Result> Add(Image image, CancellationToken cancellation);
        public Task<Result> Update(int id, Image image, CancellationToken cancellation);
        public Task<Result> Delete(int id, CancellationToken cancellation);
        public Task<List<Image>>? GetAll(Image image, CancellationToken cancellation);
        public Task<Image>? GetById(int id, CancellationToken cancellation);
    }
}
