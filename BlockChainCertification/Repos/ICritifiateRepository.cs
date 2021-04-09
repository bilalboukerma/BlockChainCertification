using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlockChainCertification.Models;

namespace BlockChainCertification.Repos
{
    interface ICritifiateRepository
    {
        List<Certification> GetCertifications();
        Certification GetCertification(int id);
        Task CreateCertification(Certification certification);
        void CreateAwardeCrtificate(AwardeCrtificate awardeCrtificate);
    }
}
