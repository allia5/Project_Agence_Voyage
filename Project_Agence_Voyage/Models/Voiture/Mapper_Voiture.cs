using System.Data;

namespace Project_Agence_Voyage.Models.Voiture
{
    public static class Mapper_Voiture
    {
        public static Voiture ToVoiture(this DataRow row)
        {
            if (row is null)
                return null;

            return new Voiture((string)row["id_voiture"], (string)row["name"], (int)row["kilometrage"], (int)row["prix"], (string)row["imagee"], (int)row["seates"]);
        }

        public static List<Voiture> ToVoitures(this DataTable table)
        {
            List<Voiture> liste = new List<Voiture>();
            foreach (DataRow row in table.Rows)
            {
                liste.Add(row.ToVoiture());
            }
            return liste;
        }
    }
}
