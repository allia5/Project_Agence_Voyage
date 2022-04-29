using Project_Agence_Voyage.Models.Pays;
using Project_Agence_Voyage.Models.Ville;

namespace Project_Agence_Voyage.Managers.Manager_Adress
{
    public interface IManager_Adress
    {
        public List<Pays> SelectPays();
        public List<Ville> SelectVille(string id_Pays);
    }
}
