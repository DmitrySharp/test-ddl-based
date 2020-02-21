using TestOrder.DL.Interfaces;
using TestOrder.Models.Entities;

namespace TestOrder.DL.Services
{
    public class TestOrderProductRepository : BaseRepository<TestOrderProduct>, ITestOrderProductRepository
    {
        public TestOrderProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }

}