using Project_Agence_Voyage.Models.Client;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Voiture;
using Project_Agence_Voyage.Models.Vol;
using System.Data;
using System.Data.SqlClient;

namespace Project_Agence_Voyage.Managers.Manager_Client
{
    public class Manager_Client : IManager_Client
    {
        private string cnStr = "Data Source=DESKTOP-2Q0OTRL\\HPSERVER;Initial Catalog=Test;Integrated Security=True";

        public List<Client> Get_All(string Username, String Password)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand("SELECT  [id_client],[username],[email],[password],[Status]  FROM [Test].[dbo].[Client] where username=@username and password = @password", connection);
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.Parameters.AddWithValue("@password", Password);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open();
            da.Fill(dt);
            return dt.ToClients();
        }

        public int Post_client(Client client)
        {
            try
            {
                SqlConnection connection = new SqlConnection(cnStr);
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO [dbo].[Client]([id_client],[username],[email],[password],[Status])     VALUES           (@Id,@Nom,@password,@email,@password,@status)", connection);
                cmd.Parameters.AddWithValue("@Id", client.id_client);
                cmd.Parameters.AddWithValue("@Nom", client.username);
                cmd.Parameters.AddWithValue("@password", client.password);
                cmd.Parameters.AddWithValue("@email", client.email);
                cmd.Parameters.AddWithValue("@status", client.Status);

                connection.Open();
                int insertedRows = cmd.ExecuteNonQuery();
                return insertedRows;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
