using Project_Agence_Voyage.Models.RecherchVoiture;
using Project_Agence_Voyage.Models.Voiture;

namespace Project_Agence_Voyage.Managers.Manager_Voiture
{
    public interface IManager_Voiture
    {
        public List<Voiture> Select_Voiture(RecherchVoiture arecherchvoiture);
    }
}
