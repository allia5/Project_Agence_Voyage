using Project_Agence_Voyage.Models.Resv_Vol;

namespace Project_Agence_Voyage.Models.Vol
{
	using Project_Agence_Voyage.Models.Ville;
    using System.Text.Json.Serialization;

    public class Vol
    {
		public string id_vol { get; set; }
		public DateTime date_depart { get; set; }
		public DateTime date_arriver { get; set; }
		public int prix { get; set; }
		public TimeSpan durè { get; set; }
		public string type { get; set; }
		public string id_ville_depart { get; set; }
		public string id_ville_arriver { get; set; }
		public Ville? ville { get; set; }
		public List<Resv_vol>? Resv_Vol { get; set; }
		[JsonConstructor]
		public Vol()
        {
             
        }
		public Vol(string id_vol_, DateTime date_depart_, DateTime date_arriver_, int prix_, TimeSpan durè_, string type_, string id_ville_depart_, string id_ville_arriver_)
		{
			this.id_vol = id_vol_;
			this.date_depart = date_depart_;
			this.date_arriver = date_arriver_;
			this.prix = prix_;
			this.durè = durè_;
			this.type = type_;
			this.id_ville_depart = id_ville_depart_;
			this.id_ville_arriver = id_ville_arriver_;
		}
	}
}
