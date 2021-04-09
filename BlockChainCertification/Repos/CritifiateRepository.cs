using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlockChainCertification.BlockChain;
using BlockChainCertification.Data;
using BlockChainCertification.Models;

namespace BlockChainCertification.Repos
{
    public class CritifiateRepository : ICritifiateRepository
    {
        private readonly AwardeCrtificateContext _context;

        public CritifiateRepository( )
        {
            _context = new AwardeCrtificateContext();// context;
        }

        public  void CreateAwardeCrtificate(AwardeCrtificate awardeCrtificate)
        {
            if (awardeCrtificate == null)
                throw new ArgumentNullException(nameof(awardeCrtificate));

            var awardeCrtificateEntries = _context.AwardeCrtificate.Where(c => c.CertificationId == awardeCrtificate.CertificationId).ToList();

            BlockChainHelper.VerifyBlockChain(awardeCrtificateEntries);
            if (awardeCrtificateEntries.Any(c => !c.IsValid))
            {
                throw new InvalidOperationException("Block Chain was invalid");
            }

            string previousBlockHash = null;
            if (awardeCrtificateEntries.Any())
            {
                var previousawardeCrtificate = awardeCrtificateEntries.Last();
                awardeCrtificate.PreviousId = previousawardeCrtificate.Id;
                previousBlockHash = previousawardeCrtificate.Hash;
            }

            var blockText = BlockHelper.ConcatData(awardeCrtificate.CertificationId, awardeCrtificate.CrtificateNumber,
                awardeCrtificate.Recipient, awardeCrtificate.provider, awardeCrtificate.Notes,
                awardeCrtificate.Moyen, awardeCrtificate.TransactionDate, previousBlockHash);
            awardeCrtificate.Hash = HashHelper.Hash(blockText);

            _context.AwardeCrtificate.Add(awardeCrtificate);
            _context.SaveChanges();

            
        }

        public async Task CreateCertification(Certification certification)
        {
            if (certification == null)
                throw new ArgumentNullException(nameof(certification));

            certification.CreateDate = DateTimeOffset.UtcNow;

            _context.Certification.Add(certification);

            await _context.SaveChangesAsync();
        }

        public Certification GetCertification(int id)
        {
            var certification =  _context.Certification
                           .Include(c => c.AwardeCrtificate)
                           .SingleOrDefault(c => c.Id == id);

            if (certification != null)
            {
                BlockChainHelper.VerifyBlockChain(certification.AwardeCrtificate);
            }

            return certification;
        }
        public  List<AwardeCrtificate> GetAwardeCrtificates(int id)
        {
            Certification certification =  _context.Certification
                           .Include(c => c.AwardeCrtificate)
                           .SingleOrDefault(c => c.Id == id);

            if (certification != null)
            {
                BlockChainHelper.VerifyBlockChain(certification.AwardeCrtificate);
            }

            return certification.AwardeCrtificate.ToList();//   Select(a => a.AwardeCrtificate).ToList(); 
        }

        public  List<Certification> GetCertifications()
        {
            
              var retu=   _context.Certification.ToList();
            return retu;
        }
      

        Certification ICritifiateRepository.GetCertification(int id)
        {
            throw new NotImplementedException();
        }
    }
}
