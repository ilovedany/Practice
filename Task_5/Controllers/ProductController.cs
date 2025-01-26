using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test1.Services;
namespace Test1.Controllers
{
    public class ProductController : ControllerBase
    {
        
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("getUsers/")]
        public ActionResult<List<User>> GetUsers()
        {
            try
            {
                var users = _productService.GetUsers(); 
                return Ok(users); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("addUser/")]
        public ActionResult<User> AddUser(User user)
        {
            try
            {
                _productService.AddUser(user);
                return Ok(user); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete]
        [Route("deleteUser/")]
        public ActionResult<User> DeleteUser(int id)
        {
            try
            {
                _productService.DeleteUser(id);
                return Ok($"Пользователь {id}  удален"); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("putUser/")]
        public ActionResult<User> PutUser(User user)
        {
            try
            {
                _productService.PutUser(user);
                return Ok(user); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        [Route("weatherforecast")]
        public IActionResult Post()
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast(
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    Summaries[Random.Shared.Next(Summaries.Length)])
            ).ToArray();

            return Ok(forecast);
        }
    }

    public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

        

        
    
}