using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubitquity.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class SingleDealController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
