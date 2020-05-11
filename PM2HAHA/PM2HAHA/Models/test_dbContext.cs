using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PM2HAHA.Models
{
    public partial class test_dbContext : DbContext
    {
        public test_dbContext()
        {
        }

        public test_dbContext(DbContextOptions<test_dbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<MstDataProcess> MstDataProcesses { get; set; }
        public virtual DbSet<MstDataRaw> MstDataRaws { get; set; }
        public virtual DbSet<MstUsers> MstUsers { get; set; }
        public virtual DbSet<MstRsi> MstRsis { get; set; }
        // public virtual DbSet<test_db> test_db { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=test_db;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
