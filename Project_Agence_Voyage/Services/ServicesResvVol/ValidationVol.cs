namespace Project_Agence_Voyage.Services.ServicesResvVol
{
    using Project_Agence_Voyage.Managers.ManagersResvVol;
    using Project_Agence_Voyage.Models.Resv_Vol;
    using static Project_Agence_Voyage.Services.Validation.Validation_Model;
    public partial class ServiceResvVol
    {
        public void ValidationVol(Resv_vol resvvol)
        {
            
           
            Validate_enry(resvvol.id_vol);
            Validate_enry(resvvol.id_passernger);

        }
    }
}
