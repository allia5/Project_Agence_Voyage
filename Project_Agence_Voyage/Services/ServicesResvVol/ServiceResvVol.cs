using Project_Agence_Voyage.Managers.ManagersResvVol;
using Project_Agence_Voyage.Models.Resv_Vol;

namespace Project_Agence_Voyage.Services.ServicesResvVol
{
    public partial class ServiceResvVol : IServiceResvVol
    {
        private readonly IResvVol reservervolmanger;
        public ServiceResvVol(IResvVol reservervolmanger)
        {
            this.reservervolmanger = reservervolmanger;
        }
       

        public int SeviceResvVol(Resv_vol reservervol)
        {
            ValidationVol(reservervol);
            return reservervolmanger.InsertReservationVol(reservervol);
        }
    }
}
