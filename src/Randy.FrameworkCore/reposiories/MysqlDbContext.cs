﻿using Microsoft.EntityFrameworkCore;
using MySQL.Data.Entity.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Randy.FrameworkCore.reposiories
{
    //todo 可抽象成接口 
    /// <summary>
    /// for test mysql dbcontext
    /// </summary>
    public partial class MysqlDbContext : DbContext
    {
        private string _connectionString = @"Server=192.168.0.102;database=usersystem;uid=root;pwd=12345678";


        public MysqlDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _connectionString = ConfigurationManager.GetConfigValue("connectionStrings");
            //home
            optionsBuilder.UseMySQL(_connectionString);
            //optionsBuilder.UseMySQL(@"Server=192.168.10.163;database=usersystem;uid=root;pwd=12345678");
        }


        public DbSet<test> Test { get; set; }

    }


    //注意linux下区分大小写
    public class test
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Id { get; set; }
    }
}