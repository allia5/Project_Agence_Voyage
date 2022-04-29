using Project_Agence_Voyage.Models.Passanger;
using System.Data;
using System.Data.SqlClient;

namespace Project_Agence_Voyage.Managers.Manager_Passanger
{
    public class Manager_Passanger : IManager_Passanger
    {
        private string cnStr = "Data Source=DESKTOP-2Q0OTRL\\HPSERVER;Initial Catalog=Test;Integrated Security=True";
        public int delete_pass_by_id(string id)
        {
            try
            {
                SqlConnection connection = new SqlConnection(cnStr);
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM [dbo].[Passanger] WHERE id_passanger=@id ", connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                int deletedRows = cmd.ExecuteNonQuery();
                return deletedRows;
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public List<Passanger> get_all_passanger()
        {
            try
            {
                SqlConnection connection = new SqlConnection(cnStr);
                SqlCommand cmd = new SqlCommand("SELECT [id_passanger],[nom],[prenom],[sexe],[date_naissance],[nationalitè],[passport_num],[email],[id_client]  FROM [dbo].[Passanger]", connection);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                connection.Open();
                da.Fill(dt);
                return dt.ToPassangers();
            }catch(Exception ex)
            {
                throw;
            }
        }

        public Passanger get_pass_by_id(string id)
        {
            try
            {
                SqlConnection connection = new SqlConnection(cnStr);
                SqlCommand cmd = new SqlCommand("SELECT [id_passanger],[nom],[prenom],[sexe],[date_naissance],[nationalitè],[passport_num],[email],[id_client]  FROM [dbo].[Passanger] where id_passanger=@id ", connection);
                cmd.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                connection.Open();
                da.Fill(dt);
                return dt.Rows[0].ToPassanger();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int post_passanger(Passanger passanger)
        {
            try
            {
                SqlConnection connection = new SqlConnection(cnStr);
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO [dbo].[Passanger]([id_passanger],[nom],[prenom],[sexe],[date_naissance],[nationalitè],[passport_num],[email],[id_client])   VALUES (@id_passanger,@Nom,@prenom,@sexe,@date_naissance,@nationalitè,@passport_num,@email)", connection);
                cmd.Parameters.AddWithValue("@id_passanger", passanger.id_passanger);
                cmd.Parameters.AddWithValue("@Nom", passanger.nom);
                cmd.Parameters.AddWithValue("@prenom", passanger.prenom);
                cmd.Parameters.AddWithValue("@date_naissance", passanger.date_naissance);
                cmd.Parameters.AddWithValue("@sexe", passanger.sexe);
                cmd.Parameters.AddWithValue("@nationalitè", passanger.nationalitè);
                cmd.Parameters.AddWithValue("@email", passanger.email);
                
                cmd.Parameters.AddWithValue("@passport_num", passanger.passport_num);

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
