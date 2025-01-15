
namespace UyariSoftBk.Modules.Product.Application.Port;

public interface IProductInputPort
{
    Task GetAllProducts();
    Task GetAllCategories();
    Task GetAllByCategories(int idCategory);
    Task GetByIdProduct(int idProduct);
}