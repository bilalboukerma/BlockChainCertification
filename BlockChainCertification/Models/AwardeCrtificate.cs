using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlockChainCertification.Models
{
    public class AwardeCrtificate : IBlockChain
    {
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
                       
        [Required]
        public string Recipient { get; set; }
        [Required]
        public string provider { get; set; }
        [Required]
        public string Notes { get; set; }
        [ForeignKey("Id")]
        public int? PreviousId { get; set; }
        [Required]
        public string CrtificateNumber { get; set; }
        [Required]
        public decimal Moyen { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTimeOffset TransactionDate { get; set; }
        [Required]
        //[ValidateNever]
        public string Hash { get; set; }

        [NotMapped]
        public bool IsValid { get; set; }

       public int CertificationId { get; set; }
   //     public virtual Certification Certification { get; set; }

        public virtual AwardeCrtificate Previous { get; set; }
    }
}
