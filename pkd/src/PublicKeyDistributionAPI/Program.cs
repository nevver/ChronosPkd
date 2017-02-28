using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace PublicKeyDistributionAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("AWSConnection");

            ////Create an PublicKey instance and save the entity to the database
            //var entry = new PublicKey()
            //{
            //    user = "alice@dot.net",
            //    key = "23j4k32m4e4oimd43idm3i32km2kjm342kem432kjn2kn2m3ekj232jn23nk2j3mkjjke23lkm23kjnjk23klmkj2n"
            //};

            //using (var context = PublicKeyContextFactory.Create(connectionString))
            //{
            //    context.Add(entry);
            //    context.SaveChanges();
            //}

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
