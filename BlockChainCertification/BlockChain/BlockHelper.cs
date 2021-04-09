using System;

namespace BlockChainCertification.BlockChain
{
    public static class BlockHelper
    {
        
       // public DateTimeOffset TransactionDate { get; set; }
        public static string ConcatData(int CrtificateId, string CrtificateNumber, string Recipient, string provider, string Notes, decimal Moyen, DateTimeOffset transactionDate, string previousBlockHash)
        {
           
            var formattedDate = transactionDate.ToString("yyyy-MM-dd");
            return $"{CrtificateId}{CrtificateNumber}{Recipient}{provider}{Notes}{Moyen}{formattedDate}{previousBlockHash}";
        }
    }
}
