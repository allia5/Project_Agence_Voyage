using Project_Agence_Voyage.Models.RecherchVille;
using Project_Agence_Voyage.Models.Vol;
using System.Data;
using System.Data.SqlClient;

namespace Project_Agence_Voyage.Managers.Manager_Vol
{
    public class Manager_Vol : IManager_Vol
    {
        private string cnStr = "Data Source=DESKTOP-2Q0OTRL\\HPSERVER;Initial Catalog=Test;Integrated Security=True";
        public List<Vol> Select_Vol_Recherch(RecherchVol arecherchvol)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [id_vol] ,[date_depart],[date_arriver],[prix],[durè],[type],[id_ville_depart],[id_ville_arriver] FROM [Test].[dbo].[Vol] where id_ville_depart=@id_v1 and id_ville_arriver=@id_v2 and date_depart=@date_d and date_arriver=@date_a ;", connection);
            cmd.Parameters.AddWithValue("@id_v1", arecherchvol.id_ville_origin);
            cmd.Parameters.AddWithValue("@id_v2", arecherchvol.id_ville_dist);
            cmd.Parameters.AddWithValue("@date_d", arecherchvol.Date_Depart);
            cmd.Parameters.AddWithValue("@date_a", arecherchvol.Date_return);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open();
            da.Fill(dt);

            return dt.ToVols();
        }
    }
}
