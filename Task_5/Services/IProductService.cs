using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Services
{
    public interface IProductService
    {
        public List<User> GetUsers();
        public void AddUser(User user);
        public void DeleteUser(int id);
        public void PutUser(User user);
        public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary);
    }
}