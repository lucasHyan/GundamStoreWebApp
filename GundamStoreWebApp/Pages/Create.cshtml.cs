using GundamStoreWebApp.Models;
using GundamStoreWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace GundamStoreWebApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IToastNotification _toastNotification;

        private IModelKitService _service;
        public CreateModel(IModelKitService service, IToastNotification toastNotification)
        {
            _service = service;
            _toastNotification = toastNotification;
        }

        [BindProperty]
        public ModelKit ModelKit { get; set; }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                _toastNotification.AddErrorToastMessage();
                return Page();
            }

            _service.AddModelKit(ModelKit);
            _toastNotification.AddSuccessToastMessage();

            return RedirectToPage("/Index");

        }
    }
}
