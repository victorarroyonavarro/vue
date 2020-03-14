using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cartelera.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        [Route("")]
        public IActionResult login()
        {
            return View();
        }
    }
}