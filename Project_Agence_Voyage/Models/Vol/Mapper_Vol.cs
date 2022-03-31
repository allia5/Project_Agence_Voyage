using System.Data;

namespace Project_Agence_Voyage.Models.Vol
{
    public static class Mapper_Vol
    {
      
            public static Vol ToVol(this DataRow row)
            {
                if (row is null)
                    return null;

                return new Vol((string)row["id_vol"], (DateTime)row["date_depart"], (DateTime)row["date_arriver"], (int)row["prix"], (TimeSpan)row["durè"], (string)row["type"], (string)row["id_ville_depart"], (string)row["id_ville_arriver"]);
            }

            public static List<Vol> ToVols(this DataTable table)
            {
                List<Vol> liste = new List<Vol>();
                foreach (DataRow row in table.Rows)
                {
                    liste.Add(row.ToVol());
                }
                return liste;
            }
        
    }
}
