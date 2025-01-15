using UyariSoftBk.Configuration.Shared;
using UyariSoftBk.Model.Dtos.Product;
using UyariSoftBk.Modules.Product.Application.Port;

namespace UyariSoftBk.Modules.Product.Infraestructure.Presenter;

public class ProductPresenter : BasePresenter<object>, IProductOutPort
{

    public void GetAllProducts(IEnumerable<ProductDto> data)
    {
        Success(data);
    }

    public void GetAllCategories(IEnumerable<CategoryDto> data)
    {
        Success(data);
    }

    public void GetAllByCategories(IEnumerable<ProductDto> data)
    {
        Success(data);
    }
}