using System.Data.Entity;
using System.Linq;
using TestOrder.BL.Interfaces;
using TestOrder.DL;
using TestOrder.Models.Entities;

namespace TestOrder.BL.Services
{
    public class TestProductCategoryService: ITestProductCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestProductCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public TestProductCategory GetByProductId(int productId)
        {
            return _unitOfWork.TestProductCategories.GetBaseQuery().Include(x=>x.Product).Include(x=>x.Category).FirstOrDefault(x => x.ProductId == productId);
           
        }
    }
}