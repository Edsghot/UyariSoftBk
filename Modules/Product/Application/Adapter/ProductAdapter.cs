
using Mapster;
using Microsoft.EntityFrameworkCore;
using UyariSoftBk.Model.Dtos.Product;
using UyariSoftBk.Modules.Event.Domain.IRepository;
using UyariSoftBk.Modules.Product.Application.Port;
using UyariSoftBk.Modules.Product.Domain.Entity;

namespace UyariSoftBk.Modules.Product.Application.Adapter;

public class ProductAdapter : IProductInputPort
{
    private readonly IProductOutPort _productOutPort;
    private readonly IProductRepository _productRepository;

    public ProductAdapter(IProductRepository repository, IProductOutPort productOutPort)
    {
        _productRepository = repository;
        _productOutPort = productOutPort;
    }
    public async Task GetAllProducts()
    {
        var products = await _productRepository.GetAllAsync<ProductEntity>();
        _productOutPort.GetAllProducts(products.Adapt<IEnumerable<ProductDto>>());
    }
    
}