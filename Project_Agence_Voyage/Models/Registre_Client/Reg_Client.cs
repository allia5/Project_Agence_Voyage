using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Project_Agence_Voyage.Models.Registre_Client
{
    public class Reg_Client
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirme_password { get; set; }
       
    }
}
