using System.Data;

namespace Project_Agence_Voyage.Models.Escale
{
    public static class Maper_Escale
    {
        public static Escale ToEscale(this DataRow row)
        {
            if (row is null)
                return null;

            return new Escale((string)row["id_Escale"], (DateTime)row["heur_depart"], (DateTime)row["heur_arriver"], (string)row["id_ville"], (string)row["id_vol"]);

        }

        public static List<Escale> ToEscales(this DataTable table)
        {
            List<Escale> liste = new List<Escale>();
            foreach (DataRow row in table.Rows)
            {
                liste.Add(row.ToEscale());
            }
            return liste;
        }
    }
}
