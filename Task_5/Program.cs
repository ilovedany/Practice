using Test1.Services;
var builder = WebApplication.CreateBuilder(args);


IServiceCollection allServices = builder.Services; // коллекция сервисов
IServiceCollection serviceCollection = allServices.AddTransient<IProductService, ProductService>(provider => new ProductService());
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();


app.UseHttpsRedirection();

app.Run();

