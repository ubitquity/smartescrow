using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubitquity.Controllers
{
    [Area("Agent")]
    [Route("Agent/[controller]/[action]")]
    public class Agent_DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
