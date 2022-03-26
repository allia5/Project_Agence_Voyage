namespace Project_Agence_Voyage.Models.Client
{
    public class Client
    {
		public string id_client { get; set; }
		public string username { get; set; }
		public string email { get; set; }
		public string password { get; set; }

		public Client(string id_client_, string username_, string email_, string password_)
		{
			this.id_client = id_client_;
			this.username = username_;
			this.email = email_;
			this.password = password_;
		}
	}
}
