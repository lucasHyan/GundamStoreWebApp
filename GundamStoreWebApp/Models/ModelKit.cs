using System.ComponentModel.DataAnnotations;

namespace GundamStoreWebApp.Models
{
    public class ModelKit
    {
        [Key]
        public int ModelKitId { get; set; }

        public string NameSlug => Name.ToLower().Replace(" ", "-");
        [Required(ErrorMessage = "Required to have a name.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Name must be between 6 and 50 characters")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Required to have a description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required to have an image URL.")]
        [Display(Name = "URL address")]
        public string ImageUri { get; set; }

        [Required(ErrorMessage = "Required to have a price.")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Required to have a ModelGrade.")]
        public string ModelGrade { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMMM yyyy}")]
        [DataType("month")]
        public DateTime RegistrationDate { get; set; }

        public string ExpressDeliveryFormated => ExpressDelivery ? "yes" : "no";
        public Boolean ExpressDelivery { get; set; }

        [Display(Name = "Brand")]
        public int? BrandID { get; set; }


    }
}
