using Microsoft.AspNetCore.Mvc;
using Project_Agence_Voyage.Models.Client;
using System.Security.Claims;

namespace Project_Agence_Voyage.Controllers
{
    public class UserController : Controller
    {
       /* [HttpGet,Route("GetCurentUser")]
        public Client GetCurentUser()
        {
            Client client = new Client();
            client = GetUser();
            return client;
        }
        private Client GetUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var userClaims = identity.Claims;
                return new Client
                {
                    Email = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Email)?.Value,
                    UserName = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value
                    
                   

                };
            }
       */
        }
    }

