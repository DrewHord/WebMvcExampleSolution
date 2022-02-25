using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvcExample.Models;

namespace WebMvcExample.Controllers {
    public class HomeController : Controller {
       
        public IActionResult Index() {
            ViewBag.Name = "Mary";
            ViewBag.FV = 99999.99;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValueModel model) {
            ViewBag.FV = model.CalculateFutureValue();
            return View(model); 
        }
    }
}
