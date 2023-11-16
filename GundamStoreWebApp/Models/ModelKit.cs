using System.ComponentModel.DataAnnotations;

namespace GundamStoreWebApp.Models
{
    public class ModelKit
    {
        public int ModelKitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public string ModelGrade { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMMM yyyy}")]
        public DateTime RegistrationDate { get; set; }

    }
}
