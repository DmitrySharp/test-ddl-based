using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TestOrder.BL.Interfaces;
using TestOrder.DL;
using TestOrder.Models.Entities;

namespace TestOrder.BL.Services
{
    public class TestOrderProductService : ITestOrderProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestOrderProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TestOrderProduct>> GetAllAsync()
        {
            var result = _unitOfWork.TestOrderProducts.GetBaseQuery().Include(x => x.Order).Include(x => x.Product);
            return await result.ToListAsync();
        }

        public async Task<IEnumerable<TestOrderProduct>> GetAllByOrderAsync(int orderId)
        {
            var result = _unitOfWork.TestOrderProducts.GetBaseQuery().Include(x => x.Order).Include(x => x.Product).Where(x => x.OrderId == orderId);
            return await result.ToListAsync();
        }

        public async Task<IEnumerable<TestOrderProduct>> GetAllByOrderIdsAsync(List<int> ordersIds)
        {
            //Include is important
            var result = _unitOfWork.TestOrderProducts.GetBaseQuery().Include(x => x.Order).Include(x => x.Product).Where(x => ordersIds.Contains(x.OrderId));
            return await result.ToListAsync();
        }
    }
}