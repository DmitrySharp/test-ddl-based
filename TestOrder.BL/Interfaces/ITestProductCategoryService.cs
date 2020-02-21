using TestOrder.Models.Entities;

namespace TestOrder.BL.Interfaces
{
    public interface ITestProductCategoryService
    {
        TestProductCategory GetByProductId(int productId);
    }
}