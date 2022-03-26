using System.Data;

namespace Project_Agence_Voyage.Models.Admin
{
    public static class Maper_Admin
    {
        public static Admin ToOAdmin(this DataRow row)
        {
            if (row is null)
                return null;

            return new Admin
            {
                Username  = (string)row["Username"],
               password = (string)row["password"],
               
            };
        }

        public static List<Admin> ToAdmin(this DataTable table)
        {
            List<Admin> liste = new List<Admin>();
            foreach (DataRow row in table.Rows)
            {
                liste.Add(row.ToOAdmin());
            }
            return liste;
        }
    }
}
