using App.Domain.Core.ServiceOn.Category.Data.Repository;
using App.Infra.Db.SqlServer.SqlServerDb;


namespace App.Infra.Repository.Ef.ServiceOn.SubCategories
{
    public class SubCategoryRepository(ServiceOnDbContext _context) : ISubcategoryRepository
    {
        public void Add(Domain.Core.ServiceOn.Category.Entities.SubCategories subcategory)
        {
          
        }

        public List<Domain.Core.ServiceOn.Category.Entities.SubCategories> AllsubCategories(int id)
        {
            return null;
        }

        public void Delete(Domain.Core.ServiceOn.Category.Entities.SubCategories subcategory)
        {
          
        }

        public List<Domain.Core.ServiceOn.Category.Entities.SubCategories> GetAll()
        {
            return null;
        }
    }
}
