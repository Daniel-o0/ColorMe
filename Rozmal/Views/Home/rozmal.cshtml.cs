using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Threading.Tasks;

namespace Rozmal.Views.Home
{
    public class rozmalModel : PageModel
    {
        [BindProperty]
        public new required IFormFile File { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPosttxt1()
        {
            if (File != null && File.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                var filePath = Path.Combine(uploadsFolder, File.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await File.CopyToAsync(stream);
                }
            }

            return Page();
        }
    }
}