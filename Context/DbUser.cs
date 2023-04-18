using Microsoft.EntityFrameworkCore;
using SimpleRegistrationProject.Models;

namespace SimpleRegistrationProject.Context
{
    public class DbUser : DbContext
    {
        public DbSet<UserRegistrationModel> UserInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433\\mssqllocaldb;Database=Users;User Id=sa;Password=123456Aa;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }
    }
}