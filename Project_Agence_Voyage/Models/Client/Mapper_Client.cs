using System.Data;

namespace Project_Agence_Voyage.Models.Client
{
    public static class Mapper_Client
    {
        public static Client ToClient(this DataRow row)
        {
            if (row is null)
                return null;

            return new Client((string)row["id_client"], (string)row["username"], (string)row["email"], (string)row["password_"], (Status)row["Status"]);
          
        }

        public static List<Client> ToClients(this DataTable table)
        {
            List<Client> liste = new List<Client>();
            foreach (DataRow row in table.Rows)
            {
                liste.Add(row.ToClient());
            }
            return liste;
        }
    }
}
