using Project_Agence_Voyage.Models.Vol;
using static Project_Agence_Voyage.Services.Validation.Validation_Model;

namespace Project_Agence_Voyage.Services.Services_Client
{
    public partial class Service_Client
    {
        private void Validation_Recherch_Vol(string ville1 , string ville2 , DateTime date_arr,DateTime date_return)
        {
            Validate_enry(ville1);
            Validate_enry(ville2);
            Validate_date(date_arr ,date_return);


        }
    }
}
