using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using PM2HAHA.Models;

namespace PM2HAHA.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult AddOrEdit()
        {
            MstUsers userModel = new MstUsers();
            return View(userModel);
        }


    }
}