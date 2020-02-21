using TestOrder.DL.Interfaces;

namespace TestOrder.DL
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
            ITestCategoryRepository testCategories, 
            ITestProductRepository testProducts, 
            ITestOrderRepository testOrders, 
            ITestProductCategoryRepository testProductCategories, 
            ITestOrderProductRepository testOrderProducts)
        {
            TestCategories = testCategories;
            TestProducts = testProducts;
            TestOrders = testOrders;
            TestProductCategories = testProductCategories;
            TestOrderProducts = testOrderProducts;
        }

        public ITestCategoryRepository TestCategories { get; }
        public ITestProductRepository TestProducts { get; }
        public ITestOrderRepository TestOrders { get; }
        public ITestProductCategoryRepository TestProductCategories { get; }
        public ITestOrderProductRepository TestOrderProducts { get; }
    }
}