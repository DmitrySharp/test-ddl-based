using TestOrder.DL.Interfaces;
using TestOrder.Models.Entities;

namespace TestOrder.DL.Services
{
    public class TestCategoryRepository : BaseRepository<TestCategory>, ITestCategoryRepository
    {
        public TestCategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }


}