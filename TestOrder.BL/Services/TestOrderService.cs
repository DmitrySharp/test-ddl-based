using System.Collections.Generic;
using System.Threading.Tasks;
using TestOrder.BL.Interfaces;
using TestOrder.DL;

namespace TestOrder.BL.Services
{
    public class TestOrderService: ITestOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestOrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Models.Entities.TestOrder>> GetAllAsync()
        {
            return await _unitOfWork.TestOrders.GetAllAsync();
        }
    }
}