using FundRaisingApi.Models.ViewModel;
using FundRaisingApi.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FundRaisingApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
           _userService = userService;
        }
        [HttpPost("UserRegistration")]
        public async Task<IActionResult> UserRegistration(UserRegistrationViewModel userRegistration)
        {
            try
            {
                if (userRegistration == null)
                {
                    return BadRequest("Invalid data");
                }
                var result = await _userService.Registration(userRegistration);
                if (result > 0)
                {
                    return Ok("Registration successful");
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return BadRequest("Registration failed");
        }

        //[HttpGet("UserLogin")]
        //public async Task<IActionResult> UserLogin(UserLoginViewModel userLogin)
        //{
        //    try
        //    {
                
        //        if (userLogin == null)
        //        {
        //            return BadRequest("Invalid data");
        //        }
        //        var user = await _userService.Login(userLogin);
        //        if (user != null)
        //        {
        //            //var token = GenerateJwtToken(foundUser);
        //            //return Ok(new { token });
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    return Unauthorized("Invalid username or password");
        //}
    }
}
