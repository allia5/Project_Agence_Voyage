using Project_Agence_Voyage.Models.RecherchVille;
using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Managers.Manager_Vol
{
    public interface IManager_Vol
    {
        public List<Vol> Select_Vol_Recherch(RecherchVol arechervol);
    }
}
