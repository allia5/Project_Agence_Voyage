namespace Project_Agence_Voyage.Models.Hotel
{
	using Project_Agence_Voyage.Models.Ville;
	public class Hotel
    {
		public string id_hotel { get; set; }
		public string name_hotel { get; set; }
		public string adress { get; set; }
		public int prix { get; set; }
		public string? imagee { get; set; }
		public int nbr_room { get; set; }
		public string id_ville { get; set; }

		public Ville? ville_h  { get; set; } 

		public Hotel(string id_hotel_, string name_hotel_, string adress_, int prix_, string imagee_, int nbr_room_, string id_ville_)
		{
			this.id_hotel = id_hotel_;
			this.name_hotel = name_hotel_;
			this.adress = adress_;
			this.prix = prix_;
			this.imagee = imagee_;
			this.nbr_room = nbr_room_;
			this.id_ville = id_ville_;
		}
	}
}
