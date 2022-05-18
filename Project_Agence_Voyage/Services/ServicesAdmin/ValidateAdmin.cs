using static Project_Agence_Voyage.Services.Validation.Validation_Model;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Voiture;
using Project_Agence_Voyage.Models.Vol;
namespace Project_Agence_Voyage.Services.ServicesAdmin
{
    public partial class ServiceAdmin
    {
        public static void ValidateHotel(Hotel hotel)
        {
        Validate_enry(hotel.adress);
        Validate_enry(hotel.name_hotel);
        Validate_enry(hotel.prix.ToString());
        Validate_enry(hotel.imagee);
        Validate_enry(hotel.id_ville);
        Validate_enry(hotel.nbr_room.ToString());
    }
        public static void ValidateVoiture(Voiture voiture)
        {

        }
        public static void ValidateVol(Vol vol)
        {
        Validate_enry(vol.prix.ToString());
        Validate_enry(vol.durè.ToString());
        Validate_enry(vol.type.ToString());
        Validate_enry(vol.id_ville_depart);
        Validate_enry(vol.id_ville_arriver);
        Validate_enry_date(vol.date_arriver);
        Validate_enry_date(vol.date_depart);
        Validate_date(vol.date_depart,vol.date_arriver);
        Valid_sym(vol.id_ville_arriver,vol.id_ville_depart);
    }
    }
}
