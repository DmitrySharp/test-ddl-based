using TestOrder.DL.Interfaces;
using TestOrder.Models.Entities;

namespace TestOrder.DL.Services
{
    public class TestProductRepository : BaseRepository<TestProduct>, ITestProductRepository
    {
        public TestProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}