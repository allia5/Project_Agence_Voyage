using Project_Agence_Voyage.Models.Admin;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Services.ServicesAdmin
{
    public interface IServiceAdmin
    {
       public int ServicePostVol(Vol vol);
        public int ServicePostHotel(Hotel hotel);
        public List<Admin> GetAdmin();
    }
}
