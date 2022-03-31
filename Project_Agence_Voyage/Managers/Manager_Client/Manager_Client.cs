using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Vol;
using System.Data;
using System.Data.SqlClient;

namespace Project_Agence_Voyage.Managers.Manager_Client
{
    public class Manager_Client : IManager_Client
    {
        private string cnStr = "Data Source=DESKTOP-2Q0OTRL\\HPSERVER;Initial Catalog=Test;Integrated Security=True";

        public List<Hotel> Select_Hotels(string id_Ville)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [id_hotel],[name_hotel] ,[adress],[prix],[imagee],[nbr_room],[id_ville] FROM [Test].[dbo].[Hotel] where id_ville=@idville", connection);
            cmd.Parameters.AddWithValue("@idville", id_Ville);
          
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open();
            da.Fill(dt);

            return dt.ToHotels();
        }

        public List<Vol> Select_Vol_Recherch( string id_ville_origin, string id_ville_dist, DateTime Date_Depart, DateTime Date_return)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [id_vol] ,[date_depart],[date_arriver],[prix],[durè],[type],[id_ville_depart],[id_ville_arriver] FROM [Test].[dbo].[Vol] where id_ville_depart=@id_v1 and id_ville_arriver=@id_v2 and date_depart=@date_d and date_arriver=@date_a ;", connection);
            cmd.Parameters.AddWithValue("@id_v1", id_ville_origin);
            cmd.Parameters.AddWithValue("@id_v2", id_ville_dist);
            cmd.Parameters.AddWithValue("@date_d", Date_Depart);
            cmd.Parameters.AddWithValue("@date_a", Date_return);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open();
            da.Fill(dt);

            return dt.ToVols();
        }
    }
}
