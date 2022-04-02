namespace Project_Agence_Voyage.Models.Client
{
	using Project_Agence_Voyage.Models.Passanger;
	public class Client
    {
		public string id_client { get; set; }
		public string username { get; set; }
		public string email { get; set; }
		public string password { get; set; }
		public Status Status { get; set; }
		public List<Passanger> passangers = new List<Passanger>();

		public Client(string id_client_, string username_, string email_, string password_)
		{
			this.id_client = id_client_;
			this.username = username_;
			this.email = email_;
			this.password = password_;
			this.Status = Status.Allowed;
		}
	}
}
