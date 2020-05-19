using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PM2HAHA.Models;

namespace PM2HAHA.Controllers
{
    public class TestUserController : Controller
    {
        public IActionResult UserTest()
        {
            TestUserContext testModel = new TestUserContext();
            return View(testModel);
        }
    }
}