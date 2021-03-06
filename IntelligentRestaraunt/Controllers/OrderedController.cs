using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;
using Newtonsoft.Json;
using IntelligentRestaraunt.Models;

namespace IntelligentRestaraunt.Controllers
{
    public class OrderedController : Controller
    {
        private readonly string baseUrl = "http://localhost:8080/api/";


        public ActionResult getOrderedItems()
        {
            IEnumerable<ItemOrder> orders = new List<ItemOrder>();
            var ord = new ItemOrder();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
             //   var tableNo = ord.tableNO;
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseTask = client.GetAsync("ordereditems/");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    orders = JsonConvert.DeserializeObject<IEnumerable<ItemOrder>>(readTask);
                }

                return View(orders);
            }
        }
    }
}