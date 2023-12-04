using GundamStoreWebApp.Models;
using GundamStoreWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System.Text.RegularExpressions;

namespace GundamStoreWebApp.Pages
{
    public class CreateModel : PageModel
    {
        public SelectList BrandOptionItems { get; set; }
        private readonly IToastNotification _toastNotification;

        private IModelKitService _service;
        public CreateModel(IModelKitService service, IToastNotification toastNotification)
        {
            _service = service;
            _toastNotification = toastNotification;
        }

        [BindProperty]
        public ModelKit ModelKit { get; set; }

        public void OnGet()
        {
            BrandOptionItems = new SelectList(_service.GetBrands(),
                                                nameof(Brand.BrandID),
                                                nameof(Brand.Description));
        }

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
