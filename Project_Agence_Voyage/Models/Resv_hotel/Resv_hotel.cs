namespace Project_Agence_Voyage.Models.Resv_hotel
{
    public class Resv_hotel
    {
		public string idres_hotel { get; set; }
		public DateTime date { get; set; }
		public int prix { get; set; }
		public int nbr_room { get; set; }
		public string id_client { get; set; }
		public string id_passanger { get; set; }
		public string id_hotel { get; set; }

		public Resv_hotel(string idres_hotel_, DateTime date_, int prix_, int nbr_room_, string id_client_, string id_passanger_, string id_hotel_)
		{
			this.idres_hotel = idres_hotel_;
			this.date = date_;
			this.prix = prix_;
			this.nbr_room = nbr_room_;
			this.id_client = id_client_;
			this.id_passanger = id_passanger_;
			this.id_hotel = id_hotel_;
		}
	}
}
