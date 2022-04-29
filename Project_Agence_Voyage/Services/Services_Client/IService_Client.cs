using Project_Agence_Voyage.Models.Client;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Login_User;
using Project_Agence_Voyage.Models.RecherchVille;
using Project_Agence_Voyage.Models.RecherchVoiture;
using Project_Agence_Voyage.Models.Registre_Client;
using Project_Agence_Voyage.Models.Voiture;
using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Services.Services_Client
{
    public interface IService_Client
    {
        public List<Vol> Recherch_Vol(RecherchVol arecherchvol);
        public List<Hotel> check_recherch_hotel(string id_ville);
        public List<Voiture> recherch_Voiture(RecherchVoiture arecherchvoiture);
        public List<Client> get_all_client(Login_User login_user);
        public int post_client(Reg_Client client);
    }
}
