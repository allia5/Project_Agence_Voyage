using Project_Agence_Voyage.Models.Voiture;
using System.Data;
using System.Data.SqlClient;

namespace Project_Agence_Voyage.Managers.Manager_Voiture
{
    public class Manager_Voiture :IManager_Voiture
    {

        private string cnStr = "Data Source=DESKTOP-2Q0OTRL\\HPSERVER;Initial Catalog=Test;Integrated Security=True";
        public List<Voiture> Select_Voiture(string id_Ville , DateTime pick_up , DateTime pick_off )
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("SELECT TOP (1000) v.[id_voiture],v.[name],v.[kilometrage],v.[prix],v.[imagee],v.[seates],v.[id_ville]  FROM [Test].[dbo].[Voiture] v , [Test].[dbo].[Resv_Voiture] r where r.pick_off <  convert(datetime,@pick_up,121) or r.pick_up > convert(datetime,@pick_off,121) and v.id_ville=@id_ville;", connection);

            cmd.Parameters.AddWithValue("@id_ville", id_Ville);
            cmd.Parameters.AddWithValue("@pick_off", pick_off);
            cmd.Parameters.AddWithValue("@pick_up", pick_up);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open();
            da.Fill(dt);

            return dt.ToVoitures();
        }
    }
}
