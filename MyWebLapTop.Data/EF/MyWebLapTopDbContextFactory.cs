using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyWebLapTop.Data.EF
{
    public class MyWebLapTopDbContextFactory : IDesignTimeDbContextFactory<MyWebLapTopDbContext>
    {
        public MyWebLapTopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("MyWebLapTopDB");

            var optionsBuilder = new DbContextOptionsBuilder<MyWebLapTopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MyWebLapTopDbContext(optionsBuilder.Options);
        }
    }
}
