using Project_Agence_Voyage.Models.Voiture;
using System.Data;
using System.Data.SqlClient;

namespace Project_Agence_Voyage.Managers.Manager_Voiture
{
    public class Manager_Voiture :IManager_Voiture
    {

        private string cnStr = "Data Source=DESKTOP-2Q0OTRL\\HPSERVER;Initial Catalog=Test;Integrated Security=True";
        public List<Voiture> Select_Voiture(string id_Ville)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [id_voiture],[name],[kilometrage],[prix],[image],[seates],[id_ville]  FROM [Test].[dbo].[Voiture] where id_ville=@id_ville", connection);

            cmd.Parameters.AddWithValue("@id_ville", id_Ville);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open();
            da.Fill(dt);

            return dt.ToVoitures();
        }
    }
}
