using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using TestOrder.BL.Interfaces;
using TestOrder.Models.View;

namespace TestOrder.Controllers
{
    //TODO: Mapper
    //TODO: Logs
    public class OrdersController : Controller
    {
        private readonly ITestOrderProductService _testOrderProductService;
        private readonly ITestOrderService _testOrderService;
        private readonly IShipmentService _shipmentService;
        public OrdersController(ITestOrderProductService testOrderProductService,
            ITestOrderService testOrderService,
            IShipmentService shipmentService)
        {
            _testOrderProductService = testOrderProductService;
            _testOrderService = testOrderService;
            _shipmentService = shipmentService;
        }

        public async Task<ActionResult> Index()
        {
            List<TestOrderProductModel> result = new List<TestOrderProductModel>();

            //TODO: Mapper
            //Get actual orders
            var orders = await _testOrderService.GetAllAsync();
            foreach (var order in orders)
            {
                var obj = new TestOrderProductModel { Order = order };
                var prods = await _testOrderProductService.GetAllByOrderAsync(order.Id);

                obj.Products = prods.Select(x => new TestProductModel
                {
                    Product = x.Product,
                    Price = x.Price,
                    Total = x.Total,
                    Quantity = x.Quantity
                })
                    .ToList();
                result.Add(obj);
            }

            return View(result);
        }


        [HttpPost]
        public async Task<JsonResult> PrepareShipments(List<int> selectedOrdersIds)
        {
            //TODO: Mapper
            List<TestShipmentModel> result = await _shipmentService.ProcessOrdersAsync(selectedOrdersIds);
            
            return new JsonResult { Data = new DemoResult { Data = result } };
        }

        //
        [HttpPost]
        public async Task<JsonResult> Orders(List<TestShipmentModel> model)
        {
            //Just return the same result for demo purposes
            return new JsonResult { Data = new DemoResult { Data = model } };
        }

    }
}