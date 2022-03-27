using System.Data;

namespace Project_Agence_Voyage.Models.Pays
{
    public static class Mapper_Pays
    {
        public static Pays ToPays(this DataRow row)
        {
            if (row is null)
                return null;

            return new Pays((string)row["id_Pays"], (string)row["code_pays"], (string)row["nom_pays"]);
        }

        public static List<Pays> ToPayss(this DataTable table)
        {
            List<Pays> liste = new List<Pays>();
            foreach (DataRow row in table.Rows)
            {
                liste.Add(row.ToPays());
            }
            return liste;
        }
    }
}
