using GundamStoreWebApp.Models;
using GundamStoreWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GundamStoreWebApp.Pages
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public ModelKit ModelKit { get; set; }


        private IModelKitService _service;
        public EditModel(IModelKitService service)
        {
            _service = service;
        }
        public IActionResult OnGet(int id)
        {
            ModelKit = _service.GetModelKit(id);

            if (ModelKit == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.EditModelKit(ModelKit);

            return RedirectToPage("/Index");

        }

        public IActionResult OnPostDelete()
        {
            _service.DeleteModelKit(ModelKit.ModelKitId);

            return RedirectToPage("/index");
        }
    }
}
