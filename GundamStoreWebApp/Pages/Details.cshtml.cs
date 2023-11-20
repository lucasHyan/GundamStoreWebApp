using GundamStoreWebApp.Models;
using GundamStoreWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GundamStoreWebApp.Pages
{
    public class DetailsModel : PageModel
    {
        private IModelKitService _service;
        public DetailsModel(IModelKitService service) 
        {
            _service = service;
        }
        public ModelKit ModelKit { get; private set; }

        public IActionResult OnGet(int id)
        {
            ModelKit = _service.GetModelKit(id);

            if (ModelKit == null)
            {
                      return NotFound();  
            }
            return Page();
        }
    }
}
