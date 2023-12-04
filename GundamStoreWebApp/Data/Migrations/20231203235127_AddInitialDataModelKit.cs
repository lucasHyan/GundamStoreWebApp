using GundamStoreWebApp.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GundamStoreWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialDataModelKit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new GundamStoreDbContext();
            context.ModelKit.AddRange(GetInitialDataModelKit());
            context.SaveChanges();
        }
        private IList<ModelKit> GetInitialDataModelKit()
        {
            return new List<ModelKit>()
            {
                new ModelKit
                {
                    Name = "Real Grade Zaku-II",
                    Description = "1/144 scale precision,Designed for customization, the kit allows for a variety of poses and includes a diverse set of accessories. ",
                    ImageUri = "/images/model_kits/RG_ZAKU2.webp",
                    Price = 99.99,
                    ModelGrade = "RG",
                    RegistrationDate = DateTime.Now,
                    ExpressDelivery = true
                },
                new ModelKit
                {
                    Name = "Real Grade Gundam RX-78",
                    Description = "Detailed 1/144 scale, dynamic design, intricate parts, customizable poses, it exemplifies Bandai's commitment to quality and authenticity in Gundam model building.",
                    ImageUri = "/images/model_kits/RG_Gundam-RX-78-2.webp",
                    Price = 79.00,
                    ModelGrade = "RG",
                    RegistrationDate = DateTime.Now,
                    ExpressDelivery = false
                },
                new ModelKit
                {
                    Name = "Real Grade Zeta Gundam",
                    Description = " 1/144 scale recreation of the iconic mobile suit. Fusing Real Grade precision with the dynamic essence of Zeta",
                    ImageUri = "/images/model_kits/RG_ZetaGundam.webp",
                    Price = 150.00,
                    ModelGrade = "RG",
                    RegistrationDate = DateTime.Now,
                    ExpressDelivery = true
                }
            };
        }
    }
}
