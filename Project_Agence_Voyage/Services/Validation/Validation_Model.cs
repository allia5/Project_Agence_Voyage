using System.Text.RegularExpressions;

namespace Project_Agence_Voyage.Services.Validation
{
    public static  class Validation_Model
    {
        public static void Validate_enry(string value)
        {
            if(value is null)
            {
                throw new ArgumentNullException();
            }
        }
       public static void  Validate_date(DateTime date1, DateTime date2)
        {
            int compare = DateTime.Compare(date1, date2);
            if(date1== DateTime.MinValue || date2 == DateTime.MinValue )
            {
                throw new ArgumentNullException();
            }
            if(compare >= 0 )
            {
                throw new Exception($"probleme in entry date");
            }
        }
        public static void Valid_sym(string pass1 ,string pass2)
        {
            if (pass1!=pass2)
            {
                throw new Exception($"invalide password");
            }
            
        }
        public static void ValidateEmailAdresse(string email)
        {
            bool isEmail = Regex.IsMatch(email,
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                throw new Exception($"email not valid");
            }
        }

    }
}
