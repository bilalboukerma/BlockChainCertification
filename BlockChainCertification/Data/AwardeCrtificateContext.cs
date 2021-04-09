using BlockChainCertification.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace BlockChainCertification.Data

{
    public class AwardeCrtificateContext : DbContext
    {
        public AwardeCrtificateContext()
            : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
             //.UseSqlServer("Data Source = (LocalDb)\\MSSQLLocalDB; Initial Catalog = ACBlockChain2;").EnableSensitiveDataLogging();
             .UseSqlite(@"Data Source=C:\BlockChain\BlockChain.db;").EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Certification>()
            //    //.HasKey(e => e.Id)
            //     .Property(c => c.Id)
            //    .ValueGeneratedOnAdd();
            //modelBuilder.Entity<AwardeCrtificate>()
            //     //.HasKey(e => e.Id)
            //     .Property(c => c.Id)
            //    .ValueGeneratedOnAdd();

            //modelBuilder.Entity<Certification>()
            //   .HasMany(c => c.AwardeCrtificate)
            //   .WithOne()
            //   .IsRequired();
        }


        public DbSet<Certification> Certification { get; set; }

        public DbSet<AwardeCrtificate> AwardeCrtificate { get; set; }
    }
}
