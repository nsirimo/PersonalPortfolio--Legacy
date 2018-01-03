using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioWebsite.Controllers
{
    public class AppController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {

            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            
            return View();
        }

        [HttpGet("resume")]
        public IActionResult Resume()
        {
            return View();
        }
    }
}
