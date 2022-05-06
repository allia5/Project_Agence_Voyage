using Project_Agence_Voyage.Models.Resv_Vol;
using System.Data.SqlClient;

namespace Project_Agence_Voyage.Managers.ManagersResvVol
{
    public class ResvVol : IResvVol
    {
        private string cnStr = "Data Source=DESKTOP-2Q0OTRL\\HPSERVER;Initial Catalog=Test;Integrated Security=True";
        private string command = "INSERT INTO [dbo].[Reserv_Vol]([id_Resv_Vol],[date],[id_vol],[id_passernger])VALUES(@id,@date,@id_vol,@id_passernger)";
        public int InsertReservationVol(Resv_vol resvvol)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.Parameters.AddWithValue("@id", resvvol.id_Resv_Vol);
            cmd.Parameters.AddWithValue("@date", resvvol.date);
            cmd.Parameters.AddWithValue("@id_vol", resvvol.id_vol);
            cmd.Parameters.AddWithValue("@id_passernger", resvvol.id_passernger);


            connection.Open();
            int insertedRows = cmd.ExecuteNonQuery();
            return insertedRows;
        }
    }
}
