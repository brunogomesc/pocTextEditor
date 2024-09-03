using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pocTextEditor.Data;
using pocTextEditor.Models;
using System.Diagnostics;

namespace pocTextEditor.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var documents = await _context.Documents.ToListAsync();

            return View(documents);

        }
        
        public IActionResult CreateDocument()
        {

            return View();

        }

    }
}
