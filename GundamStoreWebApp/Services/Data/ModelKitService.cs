using GundamStoreWebApp.Data;
using GundamStoreWebApp.Models;
using GundamStoreWebApp.Services;

namespace GundamStoreWebApp.Services.Data
{
    public class ModelKitService : IModelKitService
    {
        private GundamStoreDbContext _context;

        public ModelKitService(GundamStoreDbContext context)
        {
            _context = context;
        }
        public void AddModelKit(ModelKit modelKit)
        {
            _context.ModelKit.Add(modelKit);
            _context.SaveChanges();
        }

        public void DeleteModelKit(int id)
        {
            ModelKit foundModelKit = GetModelKit(id);
            _context.ModelKit.Remove(foundModelKit);
            _context.SaveChanges();
        }

        public void EditModelKit(ModelKit modelKit)
        {
            ModelKit foundModelKit = GetModelKit(modelKit.ModelKitId);
            foundModelKit.Name = modelKit.Name;
            foundModelKit.Description = modelKit.Description;
            foundModelKit.Price = modelKit.Price;
            foundModelKit.ModelGrade = modelKit.ModelGrade;
            foundModelKit.ExpressDelivery = modelKit.ExpressDelivery;
            foundModelKit.ImageUri = modelKit.ImageUri;
            foundModelKit.RegistrationDate = modelKit.RegistrationDate;
            foundModelKit.BrandID = modelKit.BrandID;
            _context.SaveChanges();
        }

        public IList<ModelKit> GetAllModelKits()
        {
            return _context.ModelKit.ToList();
        }

        public ModelKit GetModelKit(int id) =>
            _context.ModelKit.SingleOrDefault(item => item.ModelKitId == id);


        public IList<Brand> GetBrands() 
            => _context.Brand.ToList();

        public Brand GetBrand(int id) 
            => _context.Brand.SingleOrDefault(item => item.BrandID == id);
    }
}
