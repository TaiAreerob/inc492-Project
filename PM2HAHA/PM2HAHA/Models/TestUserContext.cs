using Microsoft.EntityFrameworkCore;

namespace PM2HAHA.Models
{
    public partial class TestUserContext : DbContext
    {
        public int UserID { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int Password { get; set; }
        public int Email { get; set; }
        public TestUserContext()
        {
        }

        public TestUserContext(DbContextOptions<TestUserContext> options)
            : base(options)
        {
        }

        // Unable to generate entity type for table 'dbo.TestUser'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=TestUser;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
