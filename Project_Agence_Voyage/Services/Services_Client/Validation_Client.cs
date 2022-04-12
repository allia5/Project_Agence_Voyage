using Project_Agence_Voyage.Models.Client;
using Project_Agence_Voyage.Models.Registre_Client;
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
        private void Validation_Recherch_Hotel(string id_ville)
        {
            Validate_enry(id_ville);
           


        }
      
        private void Validation_Recherch_Voiture(string id_ville,DateTime pick_up ,DateTime pick_off)
        {


            Validate_enry(id_ville);
            Validate_date(pick_up, pick_off);


        }
        private void Validation_Client(Reg_Client client)
        {
            Validate_enry(client.username);
            Validate_enry(client.password);
            Validate_enry(client.confirme_password);
            Valid_sym(client.password, client.confirme_password);
            ValidateEmailAdresse(client.email);




        }

    }
}
