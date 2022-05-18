using Project_Agence_Voyage.Managers.ManagerAdmin;
using Project_Agence_Voyage.Models.Admin;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Services.ServicesAdmin
{
    public partial class ServiceAdmin : IServiceAdmin
    {
        private readonly IManagerAdmin manageradmin;
        public ServiceAdmin(IManagerAdmin manageradmin)
        {
            this.manageradmin = manageradmin;
        }

        public List<Admin> GetAdmin()
        {
            return manageradmin.SelectAdmin();
        }

        public int ServicePostHotel(Hotel hotel)
        {
            hotel.id_hotel = Guid.NewGuid().ToString();
            ValidateHotel(hotel);
            return manageradmin.InsertHotel(hotel);
        }

        public int ServicePostVol(Vol vol)
        {
            vol.id_vol = Guid.NewGuid().ToString();
            ValidateVol(vol);
            return manageradmin.InsertVol(vol);
        }
    }
}
