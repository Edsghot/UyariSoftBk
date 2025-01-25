
using Mapster;
using Microsoft.EntityFrameworkCore;
using UyariSoftBk.Model.Dtos.Order;
using UyariSoftBk.Model.Dtos.Product;
using UyariSoftBk.Modules.Event.Domain.IRepository;
using UyariSoftBk.Modules.Product.Application.Port;
using UyariSoftBk.Modules.Product.Domain.Entity;

namespace UyariSoftBk.Modules.Product.Application.Adapter;

public class ProductAdapter : IProductInputPort
{
    private readonly IProductOutPort _productOutPort;
    private readonly IProductRepository _productRepository;
    private readonly DateTime _peruDateTime;

    public ProductAdapter(IProductRepository repository, IProductOutPort productOutPort)
    {
        _productRepository = repository;
        _productOutPort = productOutPort;
        
        var peruTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SA Pacific Standard Time");
        _peruDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, peruTimeZone);

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
            var categorias = await _productRepository.GetAllAsync<CategoryEntity>(x => x.Where(i => i.IdProduct == productDto.ProductId));

            productDto.Categories = categorias.Adapt<List<CategoryDto>>();
        
        }
        _productOutPort.GetAllProducts(productDtos);
    }
    public async Task GetAllCategories()
    {
        var categories = await _productRepository.GetAllAsync<CategoryEntity>();
        var categoryDtos = categories.Adapt<IEnumerable<CategoryDto>>().ToList();
        _productOutPort.GetAllCategories(categoryDtos);
    }
    
    public async Task GetAllByCategories(int idCategory)
    {
        var products = await _productRepository.GetAllAsync<ProductEntity>(x => x.Where(x => x.IdCategory == idCategory));

        var productDtos = products.Adapt<IEnumerable<ProductDto>>().ToList();
         
        foreach (var productDto in productDtos)
        {
            var githubEntities = await _productRepository.GetAllAsync<GitHubEntity>(x => x.Where(g => g.ProductId == productDto.ProductId));
            productDto.GitHub = githubEntities.Adapt<List<GitHubDto>>();

            var imageEntities = await _productRepository.GetAllAsync<ProductImageEntity>(x => x.Where(i => i.ProductId == productDto.ProductId));
            productDto.Images = imageEntities.Adapt<List<ProductImageDto>>();
            var categorias = await _productRepository.GetAllAsync<CategoryEntity>(x => x.Where(i => i.IdProduct == productDto.ProductId));

            productDto.Categories = categorias.Adapt<List<CategoryDto>>();
        
        }
        _productOutPort.GetAllByCategories(productDtos);
    }

    public async Task GetByIdProduct(int idProduct)
    {
        var products = await _productRepository.GetAsync<ProductEntity>(x => x.ProductId == idProduct);

        var productDtos = products.Adapt<ProductDto>();
         
        
            var githubEntities = await _productRepository.GetAllAsync<GitHubEntity>(x => x.Where(g => g.ProductId == productDtos.ProductId));
            productDtos.GitHub = githubEntities.Adapt<List<GitHubDto>>();

            var imageEntities = await _productRepository.GetAllAsync<ProductImageEntity>(x => x.Where(i => i.ProductId == productDtos.ProductId));
            productDtos.Images = imageEntities.Adapt<List<ProductImageDto>>();
            var categorias = await _productRepository.GetAllAsync<CategoryEntity>(x => x.Where(i => i.IdProduct == productDtos.ProductId));

            productDtos.Categories = categorias.Adapt<List<CategoryDto>>();
        
        
        _productOutPort.GetByIdProduct(productDtos);
    }
    public async Task InsertOrder(InsertOrderDto data)
    {
        var orderData = data.Adapt<OrderEntity>();
        orderData.OrderDate = _peruDateTime;

        await _productRepository.AddAsync(orderData);
        
        _productOutPort.Success(orderData,"Creado con exito!");
    }

    public async Task LastOrderPayment()
    {
        var lastOrder = (await _productRepository.GetAllAsync<OrderEntity>(x => x.Where(x => x.Paid == false))).ToList();
        
        var maxDate = lastOrder.Max(o => o.OrderDate);
        var OrderWithLastDate = await _productRepository.GetAsync<OrderEntity>(x => x.Paid == false && x.OrderDate == maxDate);

        if (OrderWithLastDate == null)
        {
            _productOutPort.NotFound("No hay ordenes por pagar");
            return;
        }
        
        var data = OrderWithLastDate.Adapt<OrderDto>();
        
        _productOutPort.Success(data,"El resultado");        
        
    }
    
    public async Task UpdateOrderStatus(int id)
    {
        var order = await _productRepository.GetAsync<OrderEntity>(x => x.OrderId == id);

        if (order == null)
        {
            _productOutPort.NotFound("No se encontro el orden");
            return;
        }
        
        if (order.Paid == false)
        {
            _productOutPort.Error("Este orden ya se pago");
            return;
        }

        order.Paid = true;
        order.PaidDate = _peruDateTime;
        
        await _productRepository.UpdateAsync(order);
        
        _productOutPort.Ok("operacion exitosa!");        
        
    }
}