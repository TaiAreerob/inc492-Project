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

            var client = new WebClient();
           var json = client.DownloadString("http://worldtimeapi.org/api/timezone/America/Argentina/Salta");
            Products m = JsonConvert.DeserializeObject<Products>(json);
            var ps = await (from p in db.test_db
                            orderby p.Id
                            select p).ToListAsync();
            return View(m);
        }
    }
}
