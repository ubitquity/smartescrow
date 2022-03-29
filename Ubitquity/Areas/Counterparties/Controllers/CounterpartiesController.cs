using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubitquity.UI.Areas.Counterparties.Controllers
{
    [Area("Counterparties")]
    [Route("Counterparties/[controller]/[action]")]
    public class CounterpartiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
