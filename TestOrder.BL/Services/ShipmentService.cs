using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestOrder.BL.Interfaces;
using TestOrder.Models.View;

namespace TestOrder.BL.Services
{
    public class ShipmentService : IShipmentService
    {
        private readonly ITestOrderProductService _testOrderProductService;
        private readonly ITestProductCategoryService _testProductCategoryService;

        public ShipmentService(
            ITestProductCategoryService testProductCategoryService, 
            ITestOrderProductService testOrderProductService)
        {
            _testProductCategoryService = testProductCategoryService;
            _testOrderProductService = testOrderProductService;
        }

        public async Task<List<TestShipmentModel>> ProcessOrdersAsync(List<int> selectedOrdersIds)
        {
            //The main idea: grouping by address + by category and result formatting

            List<TestShipmentModel> result = new List<TestShipmentModel>();
            //Get all selected orders
            var prods = await _testOrderProductService.GetAllByOrderIdsAsync(selectedOrdersIds);

            //Group by address identity (FName and LName missed in this logic according to the task statement)
            var addressesGroups = prods.GroupBy(x => x.GetAddressIdentity());

            foreach (var addressGroup in addressesGroups)
            {
                //Group by product category
                var categoryGroups = addressGroup.GroupBy(x => _testProductCategoryService.GetByProductId(x.ProductId).CategoryId);

                foreach (var categoryGroup in categoryGroups)
                {
                    if (!categoryGroup.Any())
                    {
                        continue;
                    }

                    var cgCommonOrderInfo = categoryGroup.FirstOrDefault();

                    var obj = new TestShipmentModel
                    {
                        ShipmentId = Guid.NewGuid(),
                        FirstName = cgCommonOrderInfo.Order.FirstName,
                        LastName = cgCommonOrderInfo.Order.LastName,
                        Address = cgCommonOrderInfo.Order.Address,
                        City = cgCommonOrderInfo.Order.City,
                        State = cgCommonOrderInfo.Order.State,
                        Country = cgCommonOrderInfo.Order.Country,
                        Products = categoryGroup.Select(x => new TestShipmentProductModel
                            { SKU = x.Product.SKU, Quantity = x.Quantity, /*Category = categoryGroup.Key*/ })
                    };

                    result.Add(obj);
                }
            }

            //TODO: Validate 0 Category?

            return result;
        }
    }
}