
using Mapster;
using UyariSoftBk.Model.Dtos.Product;
using UyariSoftBk.Modules.Product.Domain.Entity;

namespace UyariSoftBk.Mapping;

public class MappingConfig
{
    public static void RegisterMappings()
    {
        TypeAdapterConfig<ProductEntity, ProductDto>.NewConfig();
        TypeAdapterConfig<CategoryEntity, CategoryDto>.NewConfig();
        TypeAdapterConfig<OrderEntity, OrderDto>.NewConfig();
        TypeAdapterConfig<OrderDetailEntity, OrderDetailDto>.NewConfig();
        TypeAdapterConfig<ProductImageEntity, ProductImageDto>.NewConfig();
        TypeAdapterConfig<UserEntity, UserDto>.NewConfig();

    }
}