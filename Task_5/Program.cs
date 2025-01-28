using Test1.Services;
var builder = WebApplication.CreateBuilder(args);

string connectionString = @"Server=DESKTOP-QR21RPK;Database=Task_5;Trusted_Connection=True;";


IServiceCollection allServices = builder.Services; // коллекция сервисов


IServiceCollection serviceCollection = allServices.AddTransient<IProductService, ProductService>(provider => new ProductService(connectionString));

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();


app.UseHttpsRedirection();

app.Run();

