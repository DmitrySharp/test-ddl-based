using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestOrder.BL.Interfaces
{
    public interface ITestOrderService
    {
        Task<IEnumerable<Models.Entities.TestOrder>> GetAllAsync();
    }
}