using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicKeyDistributionAPI.Models
{
    public class PublicKeyContext : DbContext
    {
        public PublicKeyContext(DbContextOptions<PublicKeyContext> options)
            : base(options)
        {
        }

        public DbSet<PublicKey> PublicKeys { get; set; }
    }
    /// <summary>
    /// Factory class for EmployeesContext
    /// </summary>
    public static class PublicKeyContextFactory
    {
        public static PublicKeyContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PublicKeyContext>();
            optionsBuilder.UseMySQL(connectionString);

            //Ensure database creation
            var context = new PublicKeyContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            return context;
        }
    }
}