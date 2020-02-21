using System.Collections.Generic;
using Newtonsoft.Json;

namespace TestOrder.Models.View
{
    //Model for demo purposes
    public class DemoResult
    {
        public  List<TestShipmentModel> Data { get; set; } = new List<TestShipmentModel>();

        public string Json => JsonConvert.SerializeObject(Data, Formatting.Indented);
    }
}