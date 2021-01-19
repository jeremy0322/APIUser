using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using APIUser.Models;

namespace APIUser.Controllers
{
    public class SearchRecordsController : Controller
    {
        // GET: SearchRecords
        public ActionResult Index(string search)
        {
            IEnumerable<user> obj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44325/api/");

            var consumeapi = hc.GetAsync("User?search=" + search);
            consumeapi.Wait();

            var readdata = consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<IList<user>>();
                displaydata.Wait();
                obj = displaydata.Result;
            }
            return View(obj);
        }
    }
}