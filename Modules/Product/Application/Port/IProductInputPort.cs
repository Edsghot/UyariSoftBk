﻿
using Microsoft.AspNetCore.Mvc;
using UyariSoftBk.Model.Dtos.dataProduct;
using UyariSoftBk.Model.Dtos.Order;
using UyariSoftBk.Model.Dtos.Product;

namespace UyariSoftBk.Modules.Product.Application.Port;

public interface IProductInputPort
{
    Task GetAllProducts();
    Task GetAllCategories();
    Task GetAllByCategories(int idCategory);
    Task GetByIdProduct(int idProduct);
    Task InsertOrder(InsertOrderDto data);
    Task LastOrderPayment();
    Task UpdateOrderStatus( int id);
    Task RegisterProduct(InsertProductDto data);
    Task ImageUpload(ImageDto data);
}