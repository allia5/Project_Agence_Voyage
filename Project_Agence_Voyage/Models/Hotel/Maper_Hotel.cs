using System.Data;

namespace Project_Agence_Voyage.Models.Hotel
{
    public static class Maper_Hotel
    {
        public static Hotel ToHotel(this DataRow row)
        {
            if (row is null)
                return null;

            return new Hotel((string)row["id_hotel"], (string)row["name_hotel"], (string)row["adress"], (int)row["prix"], (string)row["imagee"], (int)row["nbr_room"], (string)row["id_ville"]);
        }

        public static List<Hotel> ToHotels(this DataTable table)
        {
            List<Hotel> liste = new List<Hotel>();
            foreach (DataRow row in table.Rows)
            {
                liste.Add(row.ToHotel());
            }
            return liste;
        }
    }
}
