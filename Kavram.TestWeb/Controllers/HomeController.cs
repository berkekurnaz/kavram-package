using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kavram.TestWeb.Models;
using Kavram.App;

namespace Kavram.TestWeb.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var kavram = KavramObject.Create();
            String name = "Berke";
            kavram.Update("name", name);

            return View();
        }

        public IActionResult About()
        {
            var kavram = KavramObject.Create();
            TempData["variableName"] = kavram.Get("name");
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
