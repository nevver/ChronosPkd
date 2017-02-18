using Microsoft.EntityFrameworkCore;
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
}