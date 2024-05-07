using Microsoft.EntityFrameworkCore;
using ProniaAb106.Models;

namespace ProniaAb106.DataAccesLayer
{
    public class ProniaContext : DbContext
    {
        public ProniaContext(DbContextOptions options) : base(options)
        {
           
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-LTJ1MFV\\SQLEXPRESS;Database=ProniaDb;Trusted_Connection=true;TrustServerCertificate=true");
            base.OnConfiguring(options);
        }
    }
}
