using Microsoft.AspNetCore.Mvc;
using pocTextEditor.Data;
using pocTextEditor.Models;

namespace pocTextEditor.Controllers
{
    public class CreateDocument : Controller
    {

        private readonly AppDbContext _context;
        public CreateDocument(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Document documentReceived)
        {
            if (ModelState.IsValid)
            {

                _context.Add(documentReceived);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index","Home");

            }
            else
            {
                return View("Index", documentReceived);
            }
        }

    }
}
