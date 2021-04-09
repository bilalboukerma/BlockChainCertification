
using BlockChainCertification.Models;
using BlockChainCertification.Repos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlockChainCertification.Server.Controllers
{
   
    public class AwardeCrtificateController 
    {
        private readonly ICritifiateRepository repository;
        public AwardeCrtificateController()
        {
            repository = new CritifiateRepository();
        }
        public List<Certification> Gets()
        {
            return
            repository.GetCertifications();
             
        }


        public Certification Get(int id)
        {
            return
           repository.GetCertification(id);
        }

        
        public void CreateCertification(Certification certification)
        {

             repository.CreateCertification(certification);
           
        }
        public void CreateAwardeCrtificate(AwardeCrtificate certification)
        {

            repository.CreateAwardeCrtificate(certification);

        }

        
    }
}
