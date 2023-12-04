namespace GundamStoreWebApp.Services.Memory
{
    using GundamStoreWebApp.Models;

    public class ModelKitService : IModelKitService
    {
        private IList<ModelKit> _modelKits;
        public ModelKitService()
            => LoadInitialList();



        private void LoadInitialList()
        {
            _modelKits = new List<ModelKit>()
            {
                new ModelKit
                {
                    ModelKitId = 1,
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
                    ModelKitId = 2,
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
                    ModelKitId = 3,
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
        public IList<ModelKit> GetAllModelKits()
        {
            return _modelKits;
        }

        public ModelKit GetModelKit(int id)
            => GetAllModelKits().SingleOrDefault(item => item.ModelKitId == id);

        public void AddModelKit(ModelKit modelKit)
        {
            int nextId = _modelKits.Max(item => item.ModelKitId) + 1;
            modelKit.ModelKitId = nextId;
            _modelKits.Add(modelKit);
        }

        public void EditModelKit(ModelKit modelKit)
        {
            ModelKit foundModelKit = _modelKits.SingleOrDefault(item => item.ModelKitId == modelKit.ModelKitId);
            foundModelKit.Name = modelKit.Name;
            foundModelKit.Description = modelKit.Description;
            foundModelKit.Price = modelKit.Price;
            foundModelKit.ModelGrade = modelKit.ModelGrade;
            foundModelKit.ExpressDelivery = modelKit.ExpressDelivery;
            foundModelKit.ImageUri = modelKit.ImageUri;
            foundModelKit.RegistrationDate = modelKit.RegistrationDate;


        }

        public void DeleteModelKit(int id)
        {
            ModelKit foundModelKit = GetModelKit(id);
            _modelKits.Remove(foundModelKit);
        }

        public IList<Brand> GetBrands()
        {
            throw new NotImplementedException();
        }

        public Brand GetBrand(int id)
        {
            throw new NotImplementedException();
        }
    }
}

