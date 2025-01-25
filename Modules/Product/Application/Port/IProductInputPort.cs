
using UyariSoftBk.Model.Dtos.Order;

namespace UyariSoftBk.Modules.Product.Application.Port;

public interface IProductInputPort
{
    Task GetAllProducts();
    Task GetAllCategories();
    Task GetAllByCategories(int idCategory);
    Task GetByIdProduct(int idProduct);
    Task InsertOrder(InsertOrderDto data);
}