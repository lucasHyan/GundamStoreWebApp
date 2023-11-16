using GundamStoreWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GundamStoreWebApp.Services;

namespace GundamStoreWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public IList<ModelKit> ListModelKits { get; private set; }
        public void OnGet()
        {
            ViewData["Title"] = "Home page";

            var service = new ModelKitService();

            ListModelKits = service.GetModelKits();
        }
    }
}