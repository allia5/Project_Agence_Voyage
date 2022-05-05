namespace Project_Agence_Voyage.Models.Client
{
	using Project_Agence_Voyage.Models.Passanger;
	public class Client
    {
		public string Id { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public ClientStatus Status { get; set; }
		public List<Passanger>? Passangers { get; set; }

        public Client()
        {
			Status = ClientStatus.Allowed;
            Passangers = new List<Passanger>();
        }
		public Client(string id)
		{
			this.Id = id;
		}

		public Client(string id, string username, string email, string password):this()
		{
			this.Id = id;
			this.UserName = username;
			this.Email = email;
			this.Password = password;
		}
	}
}
