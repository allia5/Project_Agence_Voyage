namespace Project_Agence_Voyage.Models.Passanger
{
	using Project_Agence_Voyage.Models.Client;
    using Project_Agence_Voyage.Models.Resv_Vol;
    using System.Text.Json.Serialization;

    public class Passanger
    {
		public string? id_passanger { get; set; }
		public string nom { get; set; }
		public string prenom { get; set; }
		public string sexe { get; set; }
		public DateTime date_naissance { get; set; }
		public string nationalitè { get; set; }
		public string passport_num { get; set; }
		public string email { get; set; }
		public string? idClient { get; set; }
		public  Client? Client { get; set; }
		public List<Resv_vol>? Resv_Vol { get; set; }

		[JsonConstructor]
		public Passanger() { }

		public Passanger(string id_passanger_, string nom_, string prenom_, string sexe_, DateTime date_naissance_, string nationalitè_, string passport_num_, string email_,string id_client)
		{
			this.id_passanger = id_passanger_;
			this.nom = nom_;
			this.prenom = prenom_;
			this.sexe = sexe_;
			this.date_naissance = date_naissance_;
			this.nationalitè = nationalitè_;
			this.passport_num = passport_num_;
			this.email = email_;
			this.idClient = id_client;
			
			
		}
	}
}
