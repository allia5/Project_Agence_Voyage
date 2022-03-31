using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Vol;
using Project_Agence_Voyage.Services.Services_Client;

namespace Project_Agence_Voyage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IService_Client service_Client;
        public ClientController(IService_Client service_Client)
        {
            this.service_Client = service_Client;
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
    }
}
