using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlockChainCertification.Models
{
    public class Certification : IBlockChain
    {
        [Key]
        //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        [Required]
        public string CertificateTitle { get; set; }
        [Required]
        public string Notes { get; set; }
       
        [Required]
        [DataType(DataType.Date)]
        public DateTimeOffset CreateDate { get; set; }

        public virtual List<AwardeCrtificate> AwardeCrtificate { get; set; }
    }
}
