
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

        var productDtos = products.Adapt<IEnumerable<ProductDto>>().ToList();

        foreach (var productDto in productDtos)
        {
            var githubEntities = await _productRepository.GetAllAsync<GitHubEntity>(x => x.Where(g => g.ProductId == productDto.ProductId));
            productDto.GitHub = githubEntities.Adapt<List<GitHubDto>>();

            var imageEntities = await _productRepository.GetAllAsync<ProductImageEntity>(x => x.Where(i => i.ProductId == productDto.ProductId));
            productDto.Images = imageEntities.Adapt<List<ProductImageDto>>();
            
            
        }

        _productOutPort.GetAllProducts(productDtos);
    }
    
}