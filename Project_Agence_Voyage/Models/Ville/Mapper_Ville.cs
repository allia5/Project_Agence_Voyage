using System.Data;

namespace Project_Agence_Voyage.Models.Ville
{
    public  static class Mapper_Ville
    {
        public static Ville ToVille(this DataRow row)
        {
            if (row is null)
                return null;

            return new Ville((string)row["id_Ville"], (string)row["nom_Ville"], (string)row["id_pays"]);
        }

        public static List<Ville> ToVilles(this DataTable table)
        {
            List<Ville> liste = new List<Ville>();
            foreach (DataRow row in table.Rows)
            {
                liste.Add(row.ToVille());
            }
            return liste;
        }
    }
}
