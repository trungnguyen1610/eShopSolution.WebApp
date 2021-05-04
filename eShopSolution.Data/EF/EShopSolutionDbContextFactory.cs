﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShopSolution.Data.EF
{
    class EShopSolutionDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
    {
       
        public EShopDbContext CreateDbContext(string[] args)
        {
            //doc file json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            //sau do ta se lay duoc string
            var connectionString = configuration.GetConnectionString("eShopSolutionDatabase");
            var optionsBuilder = new DbContextOptionsBuilder<EShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new EShopDbContext(optionsBuilder.Options);

        }
    }
}
