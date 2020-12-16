using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyWeb.Data.Context
{
   public class MyWebDbContextFactory : IDesignTimeDbContextFactory<MywebDbContext>
    {
        public MywebDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("MyWebDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<MywebDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MywebDbContext(optionsBuilder.Options);
        }
    }
    }

