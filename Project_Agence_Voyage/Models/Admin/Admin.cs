namespace Project_Agence_Voyage.Models.Admin
{
    public class Admin
    {
		public string Username { get; set; }
		public string password { get; set; }

		public Admin(string Username_, string password_)
		{
			this.Username = Username_;
			this.password = password_;
		}
	}
}
