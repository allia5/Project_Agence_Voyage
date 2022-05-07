using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Project_Agence_Voyage.Models.Client;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Login_User;
using Project_Agence_Voyage.Models.RecherchVille;
using Project_Agence_Voyage.Models.RecherchVoiture;
using Project_Agence_Voyage.Models.Registre_Client;
using Project_Agence_Voyage.Models.Resv_Vol;
using Project_Agence_Voyage.Models.Voiture;
using Project_Agence_Voyage.Models.Vol;
using Project_Agence_Voyage.Services.Services_Client;
using Project_Agence_Voyage.Services.ServicesResvVol;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Project_Agence_Voyage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ClientController : ControllerBase
    {
        private readonly IService_Client service_Client;
        private IConfiguration configuration;
        private readonly IServiceResvVol srevVol;
        public ClientController(IService_Client service_Client, IConfiguration configuration, IServiceResvVol srevVol)
        {
            this.service_Client = service_Client;
            this.configuration = configuration;
            this.srevVol = srevVol;
        }

        [HttpGet]
        public IActionResult Recherch_Vol([FromQuery] RecherchVol arecherchvol)
        {
            try
            {
                List<Vol> Vols = new List<Vol>();
                Vols=service_Client.Recherch_Vol(arecherchvol);
                return Ok(Vols);

            }catch(Exception e)
            {

                return BadRequest(e.Message);

            }
        }
       
        [HttpGet("{id_ville}")]

        public IActionResult Recherch_Hotel(string id_ville)
        {
            try
            {
                List<Hotel> Hotels = new List<Hotel>();
                Hotels = service_Client.check_recherch_hotel(id_ville);
                return Ok(Hotels);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        [HttpGet, Route("Recherch_voiture")]
        public IActionResult Recherch_Voiture_Client(RecherchVoiture arecherchvoiture)
        {
            try
            {
                List<Voiture> Voiture = new List<Voiture>();
                Voiture = service_Client.recherch_Voiture( arecherchvoiture);
                return Ok(Voiture);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }
        [HttpGet,Route("Login_User")]
        
        public IActionResult  Login_User(Login_User login_user)
        {
            
            var user = authonticated(login_user);
            if(user != null)
            {
                var token = Generitedtoken(user);
                return Ok(token);
            }
            return NotFound("error login");

        }

        private String Generitedtoken(Client client)
        {
            var keysecurity = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credential = new SigningCredentials(keysecurity,SecurityAlgorithms.HmacSha256);
            var claim = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, client.UserName),
                 new Claim(ClaimTypes.Email, client.Email)
                 
                   
             };
            var token = new JwtSecurityToken(configuration["Jwt:Issuer"] , configuration["Jwt:Audience"],claim,expires:DateTime.Now.AddMinutes(2584),signingCredentials : credential);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private Client authonticated(Login_User login_user)
        {
           List<Client> Clients = new List<Client>();
            Clients= service_Client.get_all_client(login_user);
            // Client client =Clients.FirstOrDefault(o=> o.username==username.ToLower() && o.password.ToLower() == password);
           
            return Clients.First();
        }
        [HttpPost]
        
        public  IActionResult post_client(Reg_Client client)
        {
             try
              {
                service_Client.post_client(client);
                  return Ok(client);
              }catch(Exception ex)
              {
                  return BadRequest(ex.Message);
              }
            

        }
        [HttpPost]
        public IActionResult ReserverVol(Resv_vol reservervol)
        {
            try
            {
                srevVol.SeviceResvVol(reservervol);
                return Ok(srevVol);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        
    }
}
