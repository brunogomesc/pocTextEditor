using Microsoft.AspNetCore.Mvc;
using pocTextEditor.Models;
using System.Diagnostics;

namespace pocTextEditor.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

    }
}
