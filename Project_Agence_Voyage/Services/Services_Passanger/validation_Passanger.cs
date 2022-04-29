using Project_Agence_Voyage.Models.Passanger;
using static Project_Agence_Voyage.Services.Validation.Validation_Model;

namespace Project_Agence_Voyage.Services.Services_Passanger
{
    public  partial class Service_Passanger
    { 
        public void Validation_Passanger(Passanger passanger)
        {
            Validate_enry(passanger.passport_num);
            Validate_enry(passanger.nationalitè);
            Validate_enry(passanger.nom);
            Validate_enry(passanger.prenom);
            Validate_enry_date(passanger.date_naissance);
            ValidateEmailAdresse(passanger.email);

        }
    }
}
