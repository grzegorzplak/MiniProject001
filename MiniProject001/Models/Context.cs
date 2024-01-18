using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace MiniProject001.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> MiniProject001_Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-2JK6GIJ7\\SQLEXPRESS;Database=MiniProjects;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
