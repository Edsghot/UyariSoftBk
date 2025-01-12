using UyariSoftBk.Configuration.Shared;
using UyariSoftBk.Model.Dtos.Product;

namespace UyariSoftBk.Modules.Product.Application.Port;

public interface IProductOutPort : IBasePresenter<object>
{
    void GetAllProducts(IEnumerable<ProductDto> data);
}