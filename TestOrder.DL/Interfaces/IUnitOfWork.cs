using TestOrder.DL.Interfaces;

namespace TestOrder.DL
{
    public interface IUnitOfWork
    {
        ITestCategoryRepository TestCategories { get; }
        ITestProductRepository TestProducts { get; }
        ITestOrderRepository TestOrders { get; }
        ITestProductCategoryRepository TestProductCategories { get; }
        ITestOrderProductRepository TestOrderProducts { get; }
    }
}