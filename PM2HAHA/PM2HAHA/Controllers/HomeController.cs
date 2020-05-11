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
using System.Linq.Expressions;

namespace PM2HAHA.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
       
        [HttpGet]
        public ActionResult<string> Index(int id)
        {
          
            return View(1);
        }


        [Route("")]      // Combines to define the route template "Home"
        [Route("Index")] // Combines to define the route template "Home/Index"
        [Route("/")]     // Doesn't combine, defines the route template ""
        public IActionResult Index()
        {
            try
            {
                City Datasent = new City
                {
                   name = "tesssentobj"
                };

                APICall datamap = new APICall
                {
                    status = Datasent.name
                   
                };

                using (test_dbContext ctx = new test_dbContext())
                {
                    ctx.Database.BeginTransaction();
                    MstDataRaw newdata = new MstDataRaw()
                    {
                        City = datamap.status
                    };
                    ctx.MstDataRaws.Add(newdata);
                    ctx.SaveChanges();
                    ctx.Database.CommitTransaction();
                }
            }
            catch (Exception ex)
            {

            }

            
            return View();
        }

        [HttpPost]
        public ActionResult Create(MstUsers std)
        {
            //write code to update student 
            var gg=std;
            return RedirectToAction("About");
        }

        [Route("About")] // Combines to define the route template "Home/About"
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
