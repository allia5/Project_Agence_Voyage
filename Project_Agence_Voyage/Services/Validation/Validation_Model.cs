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

    }
}
