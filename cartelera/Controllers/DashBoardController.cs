using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cartelera.Controllers
{
    [Route("dashboard")]
    public class DashBoardController : Controller
    {
        [Route("")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}