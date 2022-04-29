using Project_Agence_Voyage.Models.Client;
using Project_Agence_Voyage.Models.RecherchVille;
using Project_Agence_Voyage.Models.Registre_Client;
using Project_Agence_Voyage.Models.Vol;
using static Project_Agence_Voyage.Services.Validation.Validation_Model;

namespace Project_Agence_Voyage.Services.Services_Client
{
    public partial class Service_Client
    {
        private void Validation_Recherch_Vol(RecherchVol arecherchvol)
        {
            Validate_enry(arecherchvol.id_ville_origin);
            Validate_enry(arecherchvol.id_ville_dist);
            Validate_date(arecherchvol.Date_Depart ,arecherchvol.Date_return);


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
