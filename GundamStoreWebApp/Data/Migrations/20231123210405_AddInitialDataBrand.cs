using GundamStoreWebApp.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GundamStoreWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialDataBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new GundamStoreDbContext();
            context.Brand.AddRange(GetInitialBrandData());
            context.SaveChanges();
        }

        private IList<Brand> GetInitialBrandData()
        {
            return new List<Brand>()
            {
                new Brand() { Description = "Bandai"},
                new Brand() { Description = "Good Smile"},
                new Brand() { Description = "Funko"}
            };
        }

    }
}
