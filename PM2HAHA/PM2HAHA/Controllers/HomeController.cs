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
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PM2HAHA.Controllers
{
   
    [Route("home/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
       
        [HttpGet]
        public ActionResult<string> Index(int id)
        {
            return View(1);
        }
      //  public async Task<IActionResult> Index()
       // {
        //    String cityname = "Bangkok";
       //     var client = new WebClient();
         //     var json = client.DownloadString($"https://api.waqi.info/feed/{cityname}/?token=c5a40e7f8af3b6fac5f3ca3828fda8b05ec1e60a");
           // MstDataRaw m = JsonConvert.DeserializeObject<MstDataRaw>(json);
           // var ps = await (from p in db.test_db
           //                 orderby p.Id
           //                 select p).ToListAsync();
           // return View(m);
       // }
    }
}
