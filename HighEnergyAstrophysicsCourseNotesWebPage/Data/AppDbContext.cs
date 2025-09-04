using HighEnergyAstrophysicsCourseNotesWebPage.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HighEnergyAstrophysicsCourseNotesWebPage.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }


        public AppDbContext() : base(GetOptions())
        {
        }

        private static DbContextOptions GetOptions()
        {

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();


            var builder = new DbContextOptionsBuilder<AppDbContext>();


            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);

            return builder.Options;
        }
    }
}