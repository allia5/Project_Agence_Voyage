namespace Project_Agence_Voyage.Models.Resv_Vol
{
	using Project_Agence_Voyage.Models.Vol;
	using Project_Agence_Voyage.Models.Passanger;
	public class Resv_vol 
    {
		public string? id_Resv_Vol { get; set; }
		public DateTime? date { get; set; }
		
	
		public string id_vol { get; set; }
		public string id_passernger { get; set; }
		
		public Vol? vol { get; set; }
		public Passanger? passanger { get; set; }
		

		public Resv_vol(string id_Resv_Vol_, DateTime date_,  string id_vol_, string id_passernger_)
		{
			this.id_Resv_Vol = id_Resv_Vol_;
			this.date = date_;
			
			
			this.id_vol = id_vol_;
			this.id_passernger = id_passernger_;
			
		}
	}
}
