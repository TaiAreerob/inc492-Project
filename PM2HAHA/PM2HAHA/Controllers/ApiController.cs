using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PM2HAHA.Controllers
{
    public class ApiController : Controller
    {
        private int i;
      
        public ApiController(int num)
        {
            i = num * 5;
        }
    }
}