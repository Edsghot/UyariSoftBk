using UyariSoftBk.Configuration.Context;
using Mapster;
using Microsoft.EntityFrameworkCore;
using UyariSoftBk.Mapping;
using UyariSoftBk.Model.Dtos.Teacher;
using UyariSoftBk.Modules.Product.Application.Adapter;
using UyariSoftBk.Modules.Product.Application.Port;
using UyariSoftBk.Modules.Product.Infraestructure.Presenter;
using UyariSoftBk.Modules.Product.Infraestructure.Repository;
using UyariSoftBk.Modules.Event.Domain.IRepository;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MySqlContext>();
builder.Services.AddMapster();
MappingConfig.RegisterMappings();

builder.Services.AddScoped<IProductInputPort, ProductAdapter>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductOutPort, ProductPresenter>();


builder.Services.AddScoped<IValidator<TeacherDto>, TeacherDtoValidator>();



// Configuración de CORS para permitir cualquier origen
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Apply migrations and update database automatically
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<MySqlContext>();
    if (dbContext.Database.GetPendingMigrations().Any())
    {
        dbContext.Database.Migrate();
        Console.WriteLine("Migraciones aplicadas correctamente.");
    }
    else
    {
        dbContext.Database.EnsureCreated();
        Console.WriteLine("Base de datos ya estaba actualizada.");
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Habilitar CORS para todos los orígenes
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();