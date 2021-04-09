using System.Collections.Generic;
using System.Linq;
using BlockChainCertification.Models;

namespace BlockChainCertification.BlockChain
{
    public static class BlockChainHelper
    {
        public static void VerifyBlockChain(IList<AwardeCrtificate> awardeCrtificate)
        {
            string previousHash = null;
            foreach (var entry in awardeCrtificate.OrderBy(c => c.Id))
            {
                var previousBlock = awardeCrtificate.SingleOrDefault(c => c.Id == entry.PreviousId);
                var blockText = BlockHelper.ConcatData(
                    entry.CertificationId,
                    entry.CrtificateNumber,
                    entry.Recipient,
                    entry.provider,
                    entry.Notes,
                    entry.Moyen,
                    entry.TransactionDate,
                    previousHash);

                var blockHash = HashHelper.Hash(blockText);

                // check current block hashes, and previous block hashes, since
                // it could have been modified in DB, ie checking the chain by two blocks at a time
                entry.IsValid = blockHash == entry.Hash && previousHash == previousBlock?.Hash;

                previousHash = blockHash;
            }
        }
    }
}
