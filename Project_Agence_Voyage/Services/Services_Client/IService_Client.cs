using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Services.Services_Client
{
    public interface IService_Client
    {
        public List<Vol> Recherch_Vol(string id_ville_origin, string id_ville_dist, DateTime Date_Depart, DateTime Date_return);
    }
}
