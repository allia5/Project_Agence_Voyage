using Project_Agence_Voyage.Models.Pays;
using Project_Agence_Voyage.Models.Ville;
using System.Data;
using System.Data.SqlClient;

namespace Project_Agence_Voyage.Managers.Manager_Adress
{
    public class Manager_Adress : IManager_Adress
    {
        private string cnStr = "Data Source=DESKTOP-2Q0OTRL\\HPSERVER;Initial Catalog=Test;Integrated Security=True";
        public List<Pays> Get_Pays()
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [id_Pays],[code_pays],[nom_pays] FROM[Test].[dbo].[Pays]", connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open();
            da.Fill(dt);
            return dt.ToPayss();
        }

    

        public List<Ville> Get_Ville(string id_Pays)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [id_Ville],[nom_Ville],[id_pays] FROM [Test].[dbo].[Ville] where id_pays=@id_Pays", connection);
            cmd.Parameters.AddWithValue("@id_Pays", id_Pays);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open();
            da.Fill(dt);
            return dt.ToVilles();
        }
    }
}
