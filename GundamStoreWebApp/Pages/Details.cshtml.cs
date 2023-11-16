using GundamStoreWebApp.Models;
using GundamStoreWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GundamStoreWebApp.Pages
{
    public class DetailsModel : PageModel
    {
        public ModelKit ModelKit { get; private set; }

        public void OnGet(int id)
        {
            var service = new ModelKitService();
            ModelKit = service.GetModelKit(id);
        }
    }
}
