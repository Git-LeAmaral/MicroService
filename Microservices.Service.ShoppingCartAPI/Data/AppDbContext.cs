﻿using Microservices.Service.ShoppingCartAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Microservices.Service.ShoppingCartAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }

        
    }
}
