
namespace Project_Agence_Voyage.Models.Pays
{
	using Project_Agence_Voyage.Models.Ville;
	public class Pays 
    {
		
			public string id_Pays { get; set; }
			public string code_pays { get; set; }
		public string nom_pays { get; set; }

		public List<Ville> villes = new List<Ville>();

			public Pays(string id_Pays_, string code_pays_, string nom_pays_)
			{
				this.id_Pays = id_Pays_;
				this.code_pays = code_pays_;
				this.nom_pays = nom_pays_;
			}
		}
	
}
