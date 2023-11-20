using GundamStoreWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GundamStoreWebApp.Services;

namespace GundamStoreWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private IModelKitService _service;
        public IndexModel(IModelKitService service)
        {
            _service = service;
        }
        public IList<ModelKit> ListModelKits { get; private set; }
        public void OnGet()
        {
            ViewData["Title"] = "Home page";

            ListModelKits = _service.GetAllModelKits();
        }
    }
}