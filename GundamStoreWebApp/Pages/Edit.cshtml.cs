using GundamStoreWebApp.Models;
using GundamStoreWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace GundamStoreWebApp.Pages
{
    public class EditModel : PageModel
    {
        private readonly IToastNotification _toastNotification;

        [BindProperty]
        public ModelKit ModelKit { get; set; }


        private IModelKitService _service;
        public EditModel(IModelKitService service, IToastNotification toastNotification)
        {
            _service = service;
            _toastNotification = toastNotification;
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
                _toastNotification.AddErrorToastMessage();
                return Page();

            }

            _service.EditModelKit(ModelKit);
            _toastNotification.AddSuccessToastMessage();
            return RedirectToPage("/Index");

        }

        public IActionResult OnPostDelete()
        {
            _service.DeleteModelKit(ModelKit.ModelKitId);
            _toastNotification.AddInfoToastMessage("Item deleted successfully");

            return RedirectToPage("/index");
        }
    }
}
