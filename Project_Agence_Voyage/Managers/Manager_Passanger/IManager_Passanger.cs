using Project_Agence_Voyage.Models.Passanger;

namespace Project_Agence_Voyage.Managers.Manager_Passanger
{
    public interface IManager_Passanger
    {
        public int post_passanger(Passanger passanger);
        public int delete_pass_by_id(string id);
        public int get_pass_by_id(string id);
        public List<Passanger> get_all_passanger();
    }
}
