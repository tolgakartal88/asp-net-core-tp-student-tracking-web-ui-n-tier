using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TPStudentTracking.Data.Context;

namespace TPStudentTracking.Data.Context
{
    public class AppDbContextFactory
        : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=.;Database=TPStudentTracking;Trusted_Connection=True;TrustServerCertificate=True");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
