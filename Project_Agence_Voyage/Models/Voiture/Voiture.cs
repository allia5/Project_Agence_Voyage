namespace Project_Agence_Voyage.Models.Voiture
{
    public class Voiture
    {
		public string id_voiture { get; set; }
		public string name { get; set; }
		public int kilometrage { get; set; }
		public int prix { get; set; }
		public string imagee { get; set; }
		public int seates { get; set; }
		public string id_ville { get; set; }

		public Voiture(string id_voiture_, string name_, int kilometrage_, int prix_, string imagee_, int seates_ ,string id_ville_)
		{
			this.id_voiture = id_voiture_;
			this.name = name_;
			this.kilometrage = kilometrage_;
			this.prix = prix_;
			this.imagee = imagee_;
			this.seates = seates_;
			this.id_ville = id_ville_;
		}
	}
}
