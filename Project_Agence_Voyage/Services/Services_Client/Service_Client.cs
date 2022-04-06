using Project_Agence_Voyage.Managers.Manager_Client;
using Project_Agence_Voyage.Managers.Manager_Hotel;
using Project_Agence_Voyage.Managers.Manager_Voiture;
using Project_Agence_Voyage.Managers.Manager_Vol;
using Project_Agence_Voyage.Models.Client;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Registre_Client;
using Project_Agence_Voyage.Models.Voiture;
using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Services.Services_Client
{
    public partial class Service_Client : IService_Client
    {
        private readonly IManager_Client OClient;
        private readonly IManager_Vol OVol;
        private readonly IManager_Hotel OHotel;
        private readonly IManager_Voiture OVoiture;
        public Service_Client(IManager_Client OClient, IManager_Voiture OVoiture, IManager_Hotel OHotel, IManager_Vol OVol)
        {
            this.OClient = OClient;
            this.OVol = OVol;
            this.OHotel = OHotel;
            this.OVoiture = OVoiture;
        }

        public List<Hotel> check_recherch_hotel(string id_ville)
        {
            
            Validation_Recherch_Hotel( id_ville);
            return OHotel.Select_Hotels_By_Id(id_ville);

        }

        public List<Client> get_all_client(string Username, String Password)
        {
         return OClient.Get_All(Username,Password);
        }

        public int post_client(Reg_Client client)
        {
           
            Validation_Client(client);
            var id = Guid.NewGuid().ToString();
            Client client_ = new Client(id,client.username,client.email,client.password);
           return  OClient.Post_client(client_);

        }

        public List<Voiture> recherch_Voiture(string id_ville, DateTime pick_up, DateTime pick_off)
        {
            Validation_Recherch_Voiture(id_ville, pick_up, pick_off);
            List<Voiture> List_Voiture = new List<Voiture>();
            List_Voiture = OVoiture.Select_Voiture( id_ville,  pick_up,  pick_off);
            return List_Voiture;
        }

        public List<Vol> Recherch_Vol(string id_ville_origin, string id_ville_dist, DateTime Date_Depart, DateTime Date_return)
        {
            List<Vol> Vols = new List<Vol>();
            Validation_Recherch_Vol(id_ville_origin, id_ville_dist,  Date_Depart, Date_return);
           Vols= OVol.Select_Vol_Recherch(id_ville_origin, id_ville_dist, Date_Depart, Date_return);
            return Vols;

        }

        

    }
}
