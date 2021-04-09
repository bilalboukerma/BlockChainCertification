using BlockChainCertification.Models;
using System;

namespace BlockChainCertification.Data
{
    public static class AwardeCrtificateContextExtensions
    {
        public static void EnsureDbInitialized(this AwardeCrtificateContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Certification.AddRange(
                new Certification
                {
                    CertificateTitle= "Systemes Informatiques",
                    Notes = "Promo 2020",
                    CreateDate = DateTimeOffset.UtcNow
                },
                new Certification
                {
                    CertificateTitle = "Systemes Informatiques",
                    Notes = "Promo 2021",
                    CreateDate = DateTimeOffset.UtcNow
                }
            );

            context.SaveChanges();
        }
    }
}
