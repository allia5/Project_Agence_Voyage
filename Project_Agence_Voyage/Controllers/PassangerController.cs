using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Agence_Voyage.Models.Passanger;
using Project_Agence_Voyage.Services.Services_Passanger;

namespace Project_Agence_Voyage.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PassangerController : ControllerBase
    {
        private readonly IService_Passanger servicePassanger;
        public PassangerController(IService_Passanger servicePassanger)
        {
            this.servicePassanger = servicePassanger;
        }
        [HttpPost]
        
        public ActionResult PostPassanger(Passanger passanger)
        {
            try
            {
                servicePassanger.check_post_passanger(passanger);
                return Ok(passanger);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
