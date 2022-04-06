using Project_Agence_Voyage.Models.Client;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Registre_Client;
using Project_Agence_Voyage.Models.Voiture;
using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Services.Services_Client
{
    public interface IService_Client
    {
        public List<Vol> Recherch_Vol(string id_ville_origin, string id_ville_dist, DateTime Date_Depart, DateTime Date_return);
        public List<Hotel> check_recherch_hotel(string id_ville);
        public List<Voiture> recherch_Voiture(string id_ville,DateTime pick_up,DateTime pick_off);
        public List<Client> get_all_client(string Username, String Password);
        public int post_client(Reg_Client client);
    }
}
