using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;
using Newtonsoft.Json;
using IntelligentRestaraunt.Models;

namespace IntelligentRestaraunt.Controllers
{
    public class HomeController : Controller
    {
        private readonly string baseUrl = "http://localhost:8080/api/";
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Food()
        {
            return View();
        }

        public ActionResult Drinks()
        {
            return View();
        }

        public ActionResult Meat()
        {
            IEnumerable<productViewModel> productViewModels = new List<productViewModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseTask = client.GetAsync("productViewModel/byType/meat");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    productViewModels = JsonConvert.DeserializeObject<IEnumerable<productViewModel>>(readTask);
                }

                return View(productViewModels);
            }
        }

        public ActionResult Soup()
        {
            IEnumerable<productViewModel> productViewModels = new List<productViewModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseTask = client.GetAsync("productViewModel/byType/soup");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    productViewModels = JsonConvert.DeserializeObject<IEnumerable<productViewModel>>(readTask);
                }

                return View(productViewModels);
            }
        }

        public ActionResult Snacks()
        {
            IEnumerable<productViewModel> productViewModels = new List<productViewModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseTask = client.GetAsync("productViewModel/byType/snacks");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    productViewModels = JsonConvert.DeserializeObject<IEnumerable<productViewModel>>(readTask);
                }

                return View(productViewModels);
            }
        }

        public ActionResult Dessert()
        {
            IEnumerable<productViewModel> productViewModels = new List<productViewModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseTask = client.GetAsync("productViewModel/byType/dessert");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    productViewModels = JsonConvert.DeserializeObject<IEnumerable<productViewModel>>(readTask);
                }

                return View(productViewModels);
            }
        }

        public ActionResult SoftDrink()
        {
            IEnumerable<productViewModel> productViewModels = new List<productViewModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseTask = client.GetAsync("productViewModel/byType/sdrink");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    productViewModels = JsonConvert.DeserializeObject<IEnumerable<productViewModel>>(readTask);
                }

                return View(productViewModels);
            }
        }

        public ActionResult StrongDrink()
        {
            IEnumerable<productViewModel> productViewModels = new List<productViewModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseTask = client.GetAsync("productViewModel/byType/stdrink");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    productViewModels = JsonConvert.DeserializeObject<IEnumerable<productViewModel>>(readTask);
                }

                return View(productViewModels);
            }
        }

        public ActionResult GetproductViewModels()
        {
            IEnumerable<productViewModel> productViewModels = new List<productViewModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseTask = client.GetAsync("productViewModel/byType/snacks");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    productViewModels = JsonConvert.DeserializeObject<IEnumerable<productViewModel>>(readTask);
                }

                return View(productViewModels);
            }
        }

        public ActionResult getHelp()
        {
            var tableNo = new productViewModelOrder().tableNO;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseTask = client.GetAsync("help/needHelp/" + tableNo);
                responseTask.Wait();
            }

            Console.WriteLine("here" + tableNo);

            return RedirectToAction("Index");
        }
    }
}