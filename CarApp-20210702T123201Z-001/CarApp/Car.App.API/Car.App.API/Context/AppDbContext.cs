﻿using Car.App.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.App.API.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<CarModel> Cars { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
    }
}
