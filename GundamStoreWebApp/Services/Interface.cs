using GundamStoreWebApp.Models;

namespace GundamStoreWebApp.Services;

public interface IModelKitService 
{
     IList<ModelKit> GetAllModelKits();
     void AddModelKit(ModelKit modelKit);
     ModelKit GetModelKit(int id);
     void EditModelKit(ModelKit modelKit);
     void DeleteModelKit(int id);
}
