using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubitquity.Controllers.Agent
{
    [Area("Agent")]
    [Route("Agent/[controller]/[action]")]
    public class Agent_DealsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateDeal()
        {
            return View();
        }
    }
}
