namespace Project_Agence_Voyage.Models.Registre_Client
{
    public class Reg_Client
    {
        public string username { get; set; }

        public string email { get; set; }
        public string password { get; set; }
        public string confirme_password { get; set; }
        public Reg_Client(string username_,string password_ ,string con_password_ , string email_)
        {
            this.password = password_;
            this.email = email_;
            this.username = username_;
            this.confirme_password = con_password_;

        }
    }
}
