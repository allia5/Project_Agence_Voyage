using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Project_Agence_Voyage.Models.Admin;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Vol;
using Project_Agence_Voyage.Services.ServicesAdmin;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace Project_Agence_Voyage.Controllers
{
    public class AdminController : Controller
    {
        private readonly IServiceAdmin adminservice;
        private IConfiguration configuration;
        public AdminController(IServiceAdmin adminservice,IConfiguration configuration)
        {
            this.adminservice = adminservice;
            this.configuration = configuration;
        }
       [HttpPost,Route("PostHotel")]
        [Authorize(Roles = "Admin")]
        public IActionResult PostHotel(Hotel hotel)
        {
            try
            {
                adminservice.ServicePostHotel(hotel);
                return Ok(hotel);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost, Route("PostVol")]
       [Authorize(Roles ="Admin")]
        public IActionResult PostVol(Vol vol)
        {
            try
            {
                adminservice.ServicePostVol(vol);
                return Ok(vol);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet,Route("GetToKen")]
        public IActionResult LoginAdmin([FromBody] Admin admin)
        {
            List<Admin> adminData = new List<Admin>();
            adminData = adminservice.GetAdmin(admin);
            if (adminData.Count()!=0)
            {
                var token = Generitedtoken(admin);
                return Ok(token);
            }
            return NotFound("error Login");

        }

        private string Generitedtoken(Admin admin)
        {
            var keysecurity = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credential = new SigningCredentials(keysecurity, SecurityAlgorithms.HmacSha256);
            var claim = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,admin.Username),
                 new Claim(ClaimTypes.Role,"Admin"),
             };
            var token = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Audience"], claim, expires: DateTime.Now.AddMinutes(2584), signingCredentials: credential);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
