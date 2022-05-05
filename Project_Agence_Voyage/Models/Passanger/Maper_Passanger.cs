using System.Data;

namespace Project_Agence_Voyage.Models.Passanger
{
    public static class Maper_Passanger
    {
        public static Passanger ToPassanger(this DataRow row)
        {
            if (row is null)
                return null;

            return new Passanger((string)row["id_passanger"], (string)row["nom"], (string)row["prenom"], (string)row["sexe"], (DateTime)row["date_naissance"], (string)row["nationalitè"], (string)row["passport_num"], (string)row["email"], (string)row["id_client"]);
        }

        public static List<Passanger> ToPassangers(this DataTable table)
        {
            List<Passanger> liste = new List<Passanger>();
            foreach (DataRow row in table.Rows)
            {
                liste.Add(row.ToPassanger());
            }
            return liste;
        }
    }
}
