using Project_Agence_Voyage.Models.Client;
using Project_Agence_Voyage.Models.Hotel;
using Project_Agence_Voyage.Models.Login_User;
using Project_Agence_Voyage.Models.Voiture;
using Project_Agence_Voyage.Models.Vol;
using System.Data;
using System.Data.SqlClient;

namespace Project_Agence_Voyage.Managers.Manager_Client
{
    public class Manager_Client : IManager_Client
    {
        private string cnStr = "Data Source=DESKTOP-2Q0OTRL\\HPSERVER;Initial Catalog=Test;Integrated Security=True";

        private readonly string selectAllClientsQuery = "SELECT  id_client,username,email,password,Status  FROM Test.dbo.Client where username=@username and password = @password";
        private readonly string insertClientCommand = 
            "INSERT INTO dbo.Client(id_client,username,email,password,Status) " +
            "VALUES (@aId,@aNom,@aEmail,@aPassword,@aStatus)";
        public List<Client> SelectAllClients(Login_User login_user)
        {
            SqlConnection connection = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(selectAllClientsQuery, connection);
            cmd.Parameters.AddWithValue("@username", login_user.username);
            cmd.Parameters.AddWithValue("@password", login_user.password);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            connection.Open();
            da.Fill(dt);
            return dt.ToClients();
        }

        public int InsertClient(Client client)
        {
                SqlConnection connection = new SqlConnection(cnStr);
                SqlCommand cmd = new SqlCommand(insertClientCommand, connection);
                cmd.Parameters.AddWithValue("@aId", client.Id);
                cmd.Parameters.AddWithValue("@aNom", client.UserName);
                cmd.Parameters.AddWithValue("@aPassword", client.Password);
                cmd.Parameters.AddWithValue("@aEmail", client.Email);
                cmd.Parameters.AddWithValue("@aStatus", client.Status);

                connection.Open();
                int insertedRows = cmd.ExecuteNonQuery();
                return insertedRows;
        }

       
    }
}
