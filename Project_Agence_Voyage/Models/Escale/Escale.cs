namespace Project_Agence_Voyage.Models.Escale
{
	public class Escale
	{
		public string id_Escale { get; set; }
		public DateTime heur_depart { get; set; }
		public DateTime heur_arriver { get; set; }
		public string id_ville { get; set; }
		public string id_vol { get; set; }

		public Escale(string id_Escale_, DateTime heur_depart_, DateTime heur_arriver_, string id_ville_, string id_vol_)
		{
			this.id_Escale = id_Escale_;
			this.heur_depart = heur_depart_;
			this.heur_arriver = heur_arriver_;
			this.id_ville = id_ville_;
			this.id_vol = id_vol_;
		}
	}
}