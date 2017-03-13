using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using Impulsebuy.Db.Catalog.Models;

namespace ImpulseBuy.Db
{
    public class ImpulseBuyContext : DbContext
    {
        private IConfigurationRoot _config;

        public ImpulseBuyContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }

        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DefaultConnectionString"]);
        }
    }
}
