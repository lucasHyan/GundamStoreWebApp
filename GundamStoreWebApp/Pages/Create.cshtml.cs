using GundamStoreWebApp.Models;
using GundamStoreWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GundamStoreWebApp.Pages
{
    public class CreateModel : PageModel
    {
        private IModelKitService _service;
        public CreateModel(IModelKitService service)
        {
            _service = service;
        }

        [BindProperty]
        public ModelKit ModelKit { get; set; }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.AddModelKit(ModelKit);

            return RedirectToPage("/Index");

        }
    }
}
