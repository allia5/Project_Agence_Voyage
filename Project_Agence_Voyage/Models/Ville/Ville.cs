namespace Project_Agence_Voyage.Models.Ville
{
    public class Ville
    {
		public string id_Ville { get; set; }
		public string nom_Ville { get; set; }
		public string id_pays { get; set; }

		public Ville(string id_Ville_, string nom_Ville_, string id_pays_)
		{
			this.id_Ville = id_Ville_;
			this.nom_Ville = nom_Ville_;
			this.id_pays = id_pays_;
		}
	}
}
