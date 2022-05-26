using Project_Agence_Voyage.Models.Admin;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Voiture;
using Project_Agence_Voyage.Models.Vol;
using System.Data;
using System.Data.SqlClient;

namespace Project_Agence_Voyage.Managers.ManagerAdmin
{
    public class ManagerAdmin : IManagerAdmin
    {
        private readonly string  insertHotelCommand= "INSERT INTO [dbo].[Hotel]([id_hotel],[name_hotel],[adress],[prix],[imagee],[nbr_room],[id_ville]) VALUES(@aId,@aNom,@aadress,@prix,@image,@nbr_room,@id_ville)";
        private string cnStr = "Data Source=DESKTOP-2Q0OTRL\\HPSERVER;Initial Catalog=Test;Integrated Security=True";
        private readonly string insertVolCommand = "INSERT INTO [dbo].[Vol]([id_vol],[date_depart],[date_arriver],[prix],[durè],[type],[id_ville_depart],[id_ville_arriver])  VALUES(@aId,@datedepart,@datearriver,@prix,@dure,@type,@villed,@villea)";
        private readonly string SelectAdminQUery = "SELECT [Username],[password] FROM [dbo].[Admin] where Username=@username and password=@password";
        public int InsertHotel(Hotel hotel)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(insertHotelCommand, connection);
            cmd.Parameters.AddWithValue("@aId", hotel.id_hotel);
            cmd.Parameters.AddWithValue("@aNom", hotel.name_hotel);
            cmd.Parameters.AddWithValue("@id_ville",hotel.id_ville);
            cmd.Parameters.AddWithValue("@aadress", hotel.adress);
            cmd.Parameters.AddWithValue("@prix", hotel.prix);
            cmd.Parameters.AddWithValue("@nbr_room", hotel.nbr_room);
            cmd.Parameters.AddWithValue("@image", hotel.imagee);

            connection.Open();
            int insertedRows = cmd.ExecuteNonQuery();
            return insertedRows;
        }

        public int InsertVoiture(Voiture voiture)
        {
            return 1;
        }

        public int InsertVol(Vol vol)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(insertVolCommand, connection);
            cmd.Parameters.AddWithValue("@aId", vol.id_vol);
            cmd.Parameters.AddWithValue("@datedepart", vol.date_depart);
            cmd.Parameters.AddWithValue("@datearriver", vol.date_arriver);
            cmd.Parameters.AddWithValue("@prix", vol.prix);
            cmd.Parameters.AddWithValue("@dure", vol.durè);
            cmd.Parameters.AddWithValue("@type", vol.type);
            cmd.Parameters.AddWithValue("@villed",vol.id_ville_depart );
            cmd.Parameters.AddWithValue("@villea", vol.id_ville_arriver );

            connection.Open();
            int insertedRows = cmd.ExecuteNonQuery();
            return insertedRows;
        }

        public List<Admin> SelectAdmin(Admin admin)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(SelectAdminQUery, connection);
            cmd.Parameters.AddWithValue("@password", admin.password);
            cmd.Parameters.AddWithValue("@username", admin.Username);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open();
            da.Fill(dt);
            return dt.ToAdmin();
        }
    }
}
