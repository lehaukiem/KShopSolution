using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace kShopSolution.Data.EF
{
    public class KShopDbContextFactory : IDesignTimeDbContextFactory<KShopDbContext>
    {
        public KShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("kShopSolutionDb");


            var optionsBuilder = new DbContextOptionsBuilder<KShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new KShopDbContext(optionsBuilder.Options);
        }
    }
}
