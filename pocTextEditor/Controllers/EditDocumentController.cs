using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pocTextEditor.Data;
using pocTextEditor.Models;

namespace pocTextEditor.Controllers
{
    public class EditDocumentController : Controller
    {

        private readonly AppDbContext _context;

        public EditDocumentController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int id)
        {
            var document = await _context.Documents.FirstOrDefaultAsync(x => x.Id == id);

            return View(document);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Document documentEdited)
        {

            if (ModelState.IsValid)
            {
                var document = await _context.Documents.FirstOrDefaultAsync(x => x.Id == documentEdited.Id);

                if(document != null)
                {
                    document.Title = documentEdited.Title;
                    document.Content = documentEdited.Content;
                    document.UpdatedAt = DateTime.Now;

                    _context.Update(document);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    return View(documentEdited);
                }
            }
            else
            {
                return View(documentEdited);
            }

        }

    }
}
