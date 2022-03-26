namespace Project_Agence_Voyage.Models.Resv_voiture
{
    public class Resv_voiture
    {
		public string idresv_Voiture { get; set; }
		public DateTime date { get; set; }
		public int days { get; set; }
		public int price { get; set; }
		public DateTime pick_up { get; set; }
		public DateTime pick_off { get; set; }
		public string id_voiture { get; set; }
		public string id_client { get; set; }
		public string id_passanger { get; set; }

		public Resv_voiture(string idresv_Voiture_, DateTime date_, int days_, int price_, DateTime pick_up_, DateTime pick_off_, string id_voiture_, string id_client_, string id_passanger_)
		{
			this.idresv_Voiture = idresv_Voiture_;
			this.date = date_;
			this.days = days_;
			this.price = price_;
			this.pick_up = pick_up_;
			this.pick_off = pick_off_;
			this.id_voiture = id_voiture_;
			this.id_client = id_client_;
			this.id_passanger = id_passanger_;
		}
	}
}
