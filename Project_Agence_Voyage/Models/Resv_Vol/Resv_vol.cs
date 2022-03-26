namespace Project_Agence_Voyage.Models.Resv_Vol
{
    public class Resv_vol
    {
		public string id_Resv_Vol { get; set; }
		public DateTime date { get; set; }
		public int nb_passenger { get; set; }
		public int prix { get; set; }
		public string id_vol { get; set; }
		public string id_passernger { get; set; }
		public string id_client { get; set; }

		public Resv_vol(string id_Resv_Vol_, DateTime date_, int nb_passenger_, int prix_, string id_vol_, string id_passernger_, string id_client_)
		{
			this.id_Resv_Vol = id_Resv_Vol_;
			this.date = date_;
			this.nb_passenger = nb_passenger_;
			this.prix = prix_;
			this.id_vol = id_vol_;
			this.id_passernger = id_passernger_;
			this.id_client = id_client_;
		}
	}
}
