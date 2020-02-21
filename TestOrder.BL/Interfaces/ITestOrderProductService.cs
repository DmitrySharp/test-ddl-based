using System.Collections.Generic;
using System.Threading.Tasks;
using TestOrder.Models.Entities;

namespace TestOrder.BL.Interfaces
{
    public interface ITestOrderProductService
    {
        Task<IEnumerable<TestOrderProduct>> GetAllAsync();
        Task<IEnumerable<TestOrderProduct>> GetAllByOrderAsync(int orderId);
        Task<IEnumerable<TestOrderProduct>> GetAllByOrderIdsAsync(List<int> ordersIds);
    }
}