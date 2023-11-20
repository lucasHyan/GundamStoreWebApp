using GundamStoreWebApp.Models;

namespace GundamStoreWebApp.Services;

public interface IModelKitService
{
    public IList<ModelKit> GetAllModelKits();
    public void AddModelKit(ModelKit modelKit);
    public ModelKit GetModelKit(int id);
}
