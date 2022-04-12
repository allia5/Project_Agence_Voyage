using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Project_Agence_Voyage.Models.Client;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Registre_Client;
using Project_Agence_Voyage.Models.Voiture;
using Project_Agence_Voyage.Models.Vol;
using Project_Agence_Voyage.Services.Services_Client;
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
        public ClientController(IService_Client service_Client, IConfiguration configuration)
        {
            this.service_Client = service_Client;
            this.configuration = configuration;
        }

        [HttpGet]
        public IActionResult Recherch_Vol(string id_ville_origin, string id_ville_dist, DateTime Date_Depart, DateTime Date_return)
        {
            try
            {
                List<Vol> Vols = new List<Vol>();
                Vols=service_Client.Recherch_Vol(id_ville_origin,id_ville_dist,Date_Depart,Date_return);
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
        public IActionResult Recherch_Voiture_Client(string id_ville, DateTime pick_up, DateTime pick_off)
        {
            try
            {
                List<Voiture> Voiture = new List<Voiture>();
                Voiture = service_Client.recherch_Voiture(id_ville, pick_up, pick_off);
                return Ok(Voiture);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }
        [HttpGet,Route("Login_User")]
        
        public IActionResult  Login_User(string username, string password)
        {
            
            var user = authonticated(username, password);
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
                new Claim(ClaimTypes.NameIdentifier, client.username),
                 new Claim(ClaimTypes.Email, client.email)
                 
                   
             };
            var token = new JwtSecurityToken(configuration["Jwt:Issuer"] , configuration["Jwt:Audience"],claim,expires:DateTime.Now.AddMinutes(2584),signingCredentials : credential);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private Client authonticated(string username, string password)
        {
           List<Client> Clients = new List<Client>();
            Clients= service_Client.get_all_client(username,password);
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
        
    }
}
