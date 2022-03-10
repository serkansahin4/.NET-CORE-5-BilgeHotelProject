using BilgeHotel.Entities.Concrete;
using BilgeHotel.WebApi.Models.NewViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class SignController : ControllerBase
    {
        private readonly UserManager<Employee> _userManager;
        private readonly SignInManager<Employee> _signInManager;
        public SignController(UserManager<Employee> userManager, SignInManager<Employee> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginVM loginVM)
        {
            Employee user = await _userManager.FindByEmailAsync(loginVM.Email);
            if (user != null)
            {
                Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                if (result.Succeeded)
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.UTF8.GetBytes("bilgehoteldeneme");
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim(ClaimTypes.Email, loginVM.Email),
                            new Claim(ClaimTypes.Role, (await _userManager.GetRolesAsync(user))[0])
                        }),
                        Expires = DateTime.UtcNow.AddDays(7),
                        SigningCredentials= new SigningCredentials(new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);

                    //JWT Üretilecek nokta.
                    return Ok(tokenHandler.WriteToken(token));
                }

                return BadRequest("Giriş Başarısız.");
            }

            return BadRequest("Kullanıcı Bulunamadı.");

        }
    }
}
