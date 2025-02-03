using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_7.Services;
namespace Task_7.Controllers
{
    public class UserAdressController : ControllerBase
    {
        private readonly IUserAdressService _userAdressService;

        public UserAdressController(IUserAdressService userAdressService)
        {
            _userAdressService = userAdressService;
        }

        [HttpGet]
        [Route("getAdress/")]
        public async Task<ActionResult<IEnumerable<UserAdress>>> GetAdressAsync()
        {
            try
            {
                var users = await _userAdressService.GetAdressAsync(); 
                return Ok(users); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("addAdress/")]
        public ActionResult<UserAdress> AddAdress(UserAdress userAdress)
        {
            try
            {
                _userAdressService.AddAdress(userAdress);
                return Ok(userAdress.Adresses_Id); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete]
        [Route("deleteAdress/")]
        public ActionResult<UserAdress> DeleteAdress(int id_adress)
        {
            try
            {
                _userAdressService.DeleteAdress(id_adress);
                return Ok(); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("putAdress/")]
        public ActionResult<UserAdress> PutAdress(UserAdress userAdress)
        {
            try
            {
                _userAdressService.PutAdress(userAdress);
                return Ok(userAdress); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
