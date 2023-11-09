using GundamStoreWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GundamStoreWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public IList<ModelKit> ListModelKits { get; private set; }
        public void OnGet()
        {
            ListModelKits = new List<ModelKit>()
            {
                new ModelKit
                {
                    Id = 1,
                    Name = "Real Grade Zaku-II",
                    Description = "1/144 scale precision,Designed for customization, the kit allows for a variety of poses and includes a diverse set of accessories. ",
                    ImageUri = "/images/model_kits/RG_ZAKU2.webp",
                    Price = 99.99,
                    ModelGrade = "RG",
                    RegistrationDate = DateTime.Now,
                },
                new ModelKit
                {
                    Id = 2,
                    Name = "Real Grade Gundam RX-78",
                    Description = "Detailed 1/144 scale, dynamic design, intricate parts, customizable poses, it exemplifies Bandai's commitment to quality and authenticity in Gundam model building.",
                    ImageUri = "/images/model_kits/RG_Gundam-RX-78-2.webp",
                    Price = 78.00,
                    ModelGrade = "RG",
                    RegistrationDate = DateTime.Now,
                },
                new ModelKit
                {
                    Id = 3,
                    Name = "Real Grade Zeta Gundam",
                    Description = " 1/144 scale recreation of the iconic mobile suit. Fusing Real Grade precision with the dynamic essence of Zeta",
                    ImageUri = "/images/model_kits/RG_ZetaGundam.webp",
                    Price = 150.00,
                    ModelGrade = "RG",
                    RegistrationDate = DateTime.Now,
                }
            };
        }
    }
}