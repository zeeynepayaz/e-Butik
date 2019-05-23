using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Butik.WebUI.Repository.Concrete.EntityFramework
{
    public class DesignTimeDbContextFactory: IDesignTimeDbContextFactory<ButikContext>

    {

        public ButikContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ButikContext>();
            var connectionstring = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionstring);
            return new ButikContext(builder.Options);
        }

    }
}
