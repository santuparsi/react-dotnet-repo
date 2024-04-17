using HandsOnAPIWithJWT.Entities;
using HandsOnAPIWithJWT.Model;
using HandsOnAPIWithJWT.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HandsOnAPIWithJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        IConfiguration configuration;

        public UserController(IUserRepository userRepository,IConfiguration configuration)
        {
           this.userRepository = userRepository;
            this.configuration = configuration;
        }   

        [HttpPost,Route("Register")]
        [AllowAnonymous] //access the endpoint any any user with out login
        public IActionResult Register(User user)
        {
            try
            {
                userRepository.Register(user);
               return Ok(user);

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
       
        [HttpPost,Route("Validate")]
        [AllowAnonymous]
        public IActionResult Validate(Login login)
        {
            try
            {
                User user = userRepository.Login(login.Email, login.Password);
                JsonResponse jsonResponse = new JsonResponse();
                if(user!=null)
                {
                    jsonResponse.UserId = user.UserId;
                    jsonResponse.Name = user.Name;
                    jsonResponse.Role = user.Role;
                    jsonResponse.Token=GetToken(user);
                }
                return StatusCode(200, jsonResponse);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        private string GetToken(User? user)
        {
            var issuer = configuration["Jwt:Issuer"];
            var audience = configuration["Jwt:Audience"];
            var key = Encoding.UTF8.GetBytes(configuration["Jwt:Key"]);
            //header part
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature
            );
            //payload part
            var subject = new ClaimsIdentity(new[]
            {
                        new Claim(ClaimTypes.Name,user.Name),
                        new Claim(ClaimTypes.Role, user.Role),
                        new Claim(ClaimTypes.Email,user.Email),
                    });

            var expires = DateTime.UtcNow.AddMinutes(10);
            //signature part
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = subject,
                Expires = expires,
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = signingCredentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            return jwtToken;
        }

    }
}
