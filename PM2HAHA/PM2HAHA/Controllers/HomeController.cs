using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PM2HAHA.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Newtonsoft.Json;

namespace PM2HAHA.Controllers
{
    public class HomeController : Controller
    {
        private test_dbContext db;
        public HomeController(test_dbContext ctx)
        {
            db = ctx;
        }

        public async Task<IActionResult> Index()
        {
            String cityname = "Bangkok";
            var client = new WebClient();
              var json = client.DownloadString($"https://api.waqi.info/feed/{cityname}/?token=c5a40e7f8af3b6fac5f3ca3828fda8b05ec1e60a");
            Products m = JsonConvert.DeserializeObject<Products>(json);
           // var ps = await (from p in db.test_db
           //                 orderby p.Id
           //                 select p).ToListAsync();
            return View(m);
        }
    }
}
