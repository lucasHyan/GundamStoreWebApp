namespace GundamStoreWebApp.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string Description { get; set; }

        public ICollection<ModelKit> ModelKits { get; set; }
    }
}
