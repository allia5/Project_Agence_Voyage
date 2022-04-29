using Project_Agence_Voyage.Managers.Manager_Passanger;
using Project_Agence_Voyage.Models.Passanger;

namespace Project_Agence_Voyage.Services.Services_Passanger
{
    public partial class Service_Passanger : IService_Passanger
    {
        private readonly IManager_Passanger manager_Passanger;
        public  Service_Passanger(IManager_Passanger manager_Passanger)
        {
            this.manager_Passanger = manager_Passanger;
        }
        public int check_delete_pass_by_id(string id)
        {
            return manager_Passanger.delete_pass_by_id(id);
        }

        public List<Passanger> check_get_all_passanger()
        {
            try
            {
                return manager_Passanger.get_all_passanger();

            }
            catch(Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
           
        }

        public int check_post_passanger(Passanger passanger)
        {
            try
            {
                Validation_Passanger(passanger);
                return manager_Passanger.post_passanger(passanger);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public Passanger _check_get_pass_by_id(string id)
        {
            try
            {
                return manager_Passanger.get_pass_by_id(id);
            }
            catch(Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
            
        }
    }
}
