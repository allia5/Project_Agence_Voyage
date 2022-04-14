using Project_Agence_Voyage.Models.Passanger;

namespace Project_Agence_Voyage.Services.Services_Passanger
{
    public interface IService_Passanger
    {
        public int check_post_passanger(Passanger passanger);
        public int check_delete_pass_by_id(string id);
        public Passanger _check_get_pass_by_id(string id);
        public List<Passanger> check_get_all_passanger();
    }
}
