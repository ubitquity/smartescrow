using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubitquity.UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {           
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

      
        public IActionResult ResetPassword()
        {
            return View();
        }
    }
}
