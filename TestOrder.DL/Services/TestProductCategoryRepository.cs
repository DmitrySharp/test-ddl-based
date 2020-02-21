using TestOrder.DL.Interfaces;
using TestOrder.Models.Entities;

namespace TestOrder.DL.Services
{
    public class TestProductCategoryRepository : BaseRepository<TestProductCategory>, ITestProductCategoryRepository
    {
        public TestProductCategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}