using Project_Agence_Voyage.Models.Hotel;

namespace Project_Agence_Voyage.Managers.Manager_Hotel
{
    public interface IManager_Hotel
    {
        public List<Hotel> Select_Hotels_By_Id(string id_hotel);
    }
}
