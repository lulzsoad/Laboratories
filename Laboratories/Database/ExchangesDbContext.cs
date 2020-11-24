﻿using Laboratories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratories.Database
{
    public class ExchangesDbContext : DbContext
    {
        public ExchangesDbContext (DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<ItemEntity> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        { 
        }
    }
}
