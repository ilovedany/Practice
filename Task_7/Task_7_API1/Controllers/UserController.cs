using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_7.Services;

namespace Task_7.Controllers
{
    public class UserController : ControllerBase
    {
        
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("getUsers/")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            try
            {
                var users = await _userService.GetUsersAsync(); 
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
                _userService.AddUser(user);
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
                _userService.DeleteUser(id);
                return Ok(id); 
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
                _userService.PutUser(user);
                return Ok(user); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
  
    }
      
}