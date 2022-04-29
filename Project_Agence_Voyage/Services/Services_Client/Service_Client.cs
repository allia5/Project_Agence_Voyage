using Project_Agence_Voyage.Managers.Manager_Client;
using Project_Agence_Voyage.Managers.Manager_Hotel;
using Project_Agence_Voyage.Managers.Manager_Voiture;
using Project_Agence_Voyage.Managers.Manager_Vol;
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

        public List<Client> get_all_client(Login_User login_User)
        {
         return OClient.SelectAllClients(login_User);
        }

        public int post_client(Reg_Client client)
        {
            string password = client.password;
           
            Validation_Client(client);
            var id = Guid.NewGuid().ToString();
            password=password.Decrypt();
            Client client_ = new Client(id,client.username,client.email,password);
           return  OClient.InsertClient(client_);

        }

        public List<Voiture> recherch_Voiture(RecherchVoiture arecherchvoiture)
        {
            Validation_Recherch_Voiture(arecherchvoiture.id_ville, arecherchvoiture.pick_up, arecherchvoiture.pick_off);
            List<Voiture> List_Voiture = new List<Voiture>();
            List_Voiture = OVoiture.Select_Voiture(arecherchvoiture);
            return List_Voiture;
        }

        

        public List<Vol> Recherch_Vol(RecherchVol arecherchvol)
        {
            List<Vol> Vols = new List<Vol>();
            Validation_Recherch_Vol(arecherchvol);
           Vols= OVol.Select_Vol_Recherch(arecherchvol);
            return Vols;

        }

        

    }
}
