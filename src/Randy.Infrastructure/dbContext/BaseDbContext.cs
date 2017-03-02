﻿using Microsoft.EntityFrameworkCore;
using MySQL.Data.Entity.Extensions;
using Randy.FrameworkCore;
using Randy.FrameworkCore.reposiories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Randy.Infrastructure
{
    public partial class BaseDbContext : DbContext, IDbContext
    {
        private string _connectionString = ConfigurationManager.GetConfigValue("connectionStrings");


        public BaseDbContext() { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL(_connectionString);
        }

        public DbContext GetCurrentDbcontext()
        {
            return this;
        }

        public DbSet<test> Test { get; set; }

    }


}