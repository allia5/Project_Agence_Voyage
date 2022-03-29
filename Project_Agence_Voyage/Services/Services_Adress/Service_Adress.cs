using Project_Agence_Voyage.Managers.Manager_Adress;
using Project_Agence_Voyage.Models.Pays;
using Project_Agence_Voyage.Models.Ville;

namespace Project_Agence_Voyage.Services.Services_Adress
{
    public class Service_Adress : IService_Adress
    {
        public readonly IManager_Adress manager_Adress;

        public  Service_Adress(IManager_Adress manager_Adress)
        {
            this.manager_Adress = manager_Adress;
        }
        public List<Pays> S_Get_Pays()
        {
            try
            {
              return  manager_Adress.Get_Pays();

            }catch(Exception E)
            {
                throw new Exception($"{ E.Message }");
            }
        }

        public List<Ville> S_Get_Ville(string id_pays)
        {
            throw new NotImplementedException();
        }
    }
}
