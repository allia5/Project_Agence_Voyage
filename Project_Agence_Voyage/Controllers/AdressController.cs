using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_Agence_Voyage.Models.Pays;
using Project_Agence_Voyage.Models.Ville;
using Project_Agence_Voyage.Services.Services_Adress;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_Agence_Voyage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressController : ControllerBase
    {
        public readonly IService_Adress Service_addr;
         public AdressController(IService_Adress Service_addr)
        {
            this.Service_addr = Service_addr;
        }
        // GET: api/<AdressController>
        [Authorize]
        [HttpGet]
        public IActionResult GetPays()
        {
            try
            {
                List<Pays> pays = new List<Pays>();
               pays = Service_addr.S_Get_Pays();
                return Ok(pays);
            }catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        // GET api/<AdressController>/5
        [HttpGet("{id}")]
        public IActionResult GetVilles(string id)
        {
            try
            {
                List<Ville> villes = new List<Ville>();
               villes= Service_addr.S_Get_Ville(id);
                return Ok(villes);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

            // POST api/<AdressController>
        

        // PUT api/<AdressController>/5
       

        // DELETE api/<AdressController>/5
       
    }
}
