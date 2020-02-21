using System.Collections.Generic;
using System.Threading.Tasks;
using TestOrder.Models.View;

namespace TestOrder.BL.Interfaces
{
    public interface IShipmentService
    {
        Task<List<TestShipmentModel>> ProcessOrdersAsync(List<int> selectedOrdersIds);
    }
}