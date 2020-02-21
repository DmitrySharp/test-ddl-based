using TestOrder.DL.Interfaces;

namespace TestOrder.DL.Services
{
    public class TestOrderRepository : BaseRepository<Models.Entities.TestOrder>, ITestOrderRepository
    {
        public TestOrderRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}