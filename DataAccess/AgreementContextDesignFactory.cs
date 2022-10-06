using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AgreementContextDesignFactory : IDesignTimeDbContextFactory<DBContextYEYAPI>
    {
        IConfigurationRoot _configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build();
        public DBContextYEYAPI CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContextYEYAPI>();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("wmgDb"), b => b.MigrationsAssembly("DataAccess"));

            return new DBContextYEYAPI(optionsBuilder.Options);
        }
    }
}
