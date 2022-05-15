using Microsoft.AspNetCore.Mvc;

namespace Project_Agence_Voyage.Controllers
{
    public class AdminController : Controller
    {
       [HttpPost,Route("PostHotel")]
       public IActionResult PostHotel()
        {

        }
        [HttpPost, Route("PostVol")]
        public IActionResult PostVol(Volatile vol)
        {

        }
        [HttpPost, Route("PostVoiture")]
        public IActionResult PostVoiture()
        {

        }
    }
}
