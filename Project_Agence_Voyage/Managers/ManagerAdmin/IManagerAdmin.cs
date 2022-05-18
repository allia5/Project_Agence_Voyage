using Project_Agence_Voyage.Models.Admin;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Voiture;
using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Managers.ManagerAdmin
{
    public interface IManagerAdmin
    {
        public int InsertHotel(Hotel hotel);
        public int InsertVol(Vol vol);
        public int InsertVoiture(Voiture voiture);
        public List<Admin> SelectAdmin();
    }
}
