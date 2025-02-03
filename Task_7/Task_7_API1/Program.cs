using Task_7.Services;

var builder = WebApplication.CreateBuilder(args);

string connectionString = @"Server=DESKTOP-QR21RPK;Database=Task_5;Trusted_Connection=True;";

IServiceCollection services = builder.Services;

services.AddTransient<IUserService>(provider => new UserService(connectionString));
services.AddTransient<IUserAdressService>(provider => new UserAdressService(connectionString));

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();

app.UseHttpsRedirection();

app.Run();