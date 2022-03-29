using Project_Agence_Voyage.Models.Pays;
using Project_Agence_Voyage.Models.Ville;

namespace Project_Agence_Voyage.Services.Services_Adress
{
    public interface IService_Adress
    {
        public List<Pays> S_Get_Pays();
        public List<Ville> S_Get_Ville( string id_pays);
    }
}
