using Project_Agence_Voyage.Models.Client;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Managers.Manager_Client
{
    public interface IManager_Client
    {
        public List<Client> Get_All(string Username ,String Password);
       
    }
}
