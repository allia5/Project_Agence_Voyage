using Project_Agence_Voyage.Models.Hotel;
using System.Data;
using System.Data.SqlClient;

namespace Project_Agence_Voyage.Managers.Manager_Hotel
{
    public class Manager_Hotel : IManager_Hotel
    {
        private string cnStr = "Data Source=DESKTOP-2Q0OTRL\\HPSERVER;Initial Catalog=Test;Integrated Security=True";
        public List<Hotel> Select_Hotels_By_Id(string id_hotel)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [id_hotel],[name_hotel] ,[adress],[prix],[imagee],[nbr_room],[id_ville] FROM [Test].[dbo].[Hotel] where id_ville=@idville", connection);
            cmd.Parameters.AddWithValue("@idville", id_hotel);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open();
            da.Fill(dt);

            return dt.ToHotels();
        }
    }
}
