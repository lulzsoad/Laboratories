using Laboratories.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace Laboratories.Controllers
{
    
    public class AjaxController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
