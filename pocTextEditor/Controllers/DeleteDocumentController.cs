using Microsoft.AspNetCore.Mvc;
using pocTextEditor.Data;
using Microsoft.EntityFrameworkCore;

namespace pocTextEditor.Controllers
{
    public class DeleteDocumentController : Controller
    {

        private readonly AppDbContext _context;

        public DeleteDocumentController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Delete(int id)
        {
            var document = await _context.Documents.FirstOrDefaultAsync(d => d.Id == id);

            if (document != null)
            {
                _context.Remove(document);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
