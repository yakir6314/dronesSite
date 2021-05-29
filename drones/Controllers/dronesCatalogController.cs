using drones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace drones.Controllers
{
    public class dronesCatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}