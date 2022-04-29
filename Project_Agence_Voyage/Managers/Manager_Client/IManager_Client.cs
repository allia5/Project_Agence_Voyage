using Project_Agence_Voyage.Models.Client;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Login_User;
using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Managers.Manager_Client
{
    public interface IManager_Client
    {
        public List<Client> SelectAllClients(Login_User login_User);
       public int InsertClient(Client client);
       
    }
}
