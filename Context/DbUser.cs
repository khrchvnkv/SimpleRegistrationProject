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
                "Server=localhost,32772\\mssqllocaldb; Database=Users; Trusted_Connection=true");
        }
    }
}