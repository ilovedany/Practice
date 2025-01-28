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
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            try
            {
                var users = await _productService.GetUsersAsync(); 
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
                return Ok($"Id = {user.Id}"); 
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
  
    }
      
}