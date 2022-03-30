using Project_Agence_Voyage.Managers.Manager_Client;
using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Services.Services_Client
{
    public partial class Service_Client : IService_Client
    {
        private readonly IManager_Client OClient;
        public Service_Client(IManager_Client OClient)
        {
            this.OClient = OClient;
        }
        public List<Vol> Recherch_Vol(string id_ville_origin, string id_ville_dist, DateTime Date_Depart, DateTime Date_return)
        {
            List<Vol> Vols = new List<Vol>();
            Validation_Recherch_Vol(id_ville_origin, id_ville_dist,  Date_Depart, Date_return);
           Vols= OClient.Select_Vol_Recherch(id_ville_origin, id_ville_dist, Date_Depart, Date_return);
            return Vols;

        }
    }
}
