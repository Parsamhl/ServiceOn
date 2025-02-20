using App.Domain.Core.ServiceOn.Base.Data;
using App.Domain.Core.ServiceOn.Base.Entities;
using App.Domain.Core.ServiceOn.Resualt;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repository.Ef.ServiceOn.Base
{
    public class ImageRepository(ServiceOnDbContext _context) : IImageRepository
    {
        public async Task<Result> Add(Image image, CancellationToken cancellation)
        {
            if (image is null)
            {
                return new Result(false, "Image Is Null");
            }
            await _context.Images.AddAsync(image);
            await _context.SaveChangesAsync();

            return new Result(true, "Success");
        }

        public async Task<Result> Delete(int id, CancellationToken cancellation)
        {
            var image = await _context.Images.FirstOrDefaultAsync(x => x.Id == id);
            if (image is null)
                return new Result(false, "Image Not Found.");

            _context.Images.Remove(image);
            await _context.SaveChangesAsync();

            return new Result(true, "Success");
        }

        public Task<List<Image>>? GetAll(Image image, CancellationToken cancellation)
        {
            return _context.Images.AsNoTracking().ToListAsync();
        }

        public async Task<Image>? GetById(int id, CancellationToken cancellation)
        {
            return await _context.Images.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Result> Update(int id, Image image, CancellationToken cancellation)
        {
            var img = await _context.Images.FirstOrDefaultAsync(x => x.Id == id);
            if (img is null)
                return new Result(false, "Image Not Found.");

            img.Path = image.Path;

            await _context.SaveChangesAsync();

            return new Result(true, "Success");
        }

        
    }
}
