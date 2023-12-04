using GundamStoreWebApp.Models;
using GundamStoreWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GundamStoreWebApp.Pages
{
    public class DetailsModel : PageModel
    {
        private IModelKitService _service;
        public string BrandDescription { get; set; }
        public DetailsModel(IModelKitService service) 
        {
            _service = service;
        }
        public ModelKit ModelKit { get; private set; }

        public IActionResult OnGet(int id)
        {
            ModelKit = _service.GetModelKit(id);
            if (ModelKit.BrandID is not null)
            {
            BrandDescription = _service.GetBrand(ModelKit.BrandID.Value).Description;
            }

            if (ModelKit == null)
            {
                      return NotFound();  
            }
            return Page();
        }
    }
}
