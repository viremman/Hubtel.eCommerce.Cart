using Hubtel.eCommerce.Cart.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.eCommerce.Cart.Api.Data.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Entities.Cart> Carts { get; set; }
        //public DbSet<Entities.Customer> Customers { get; set; }
        //public DbSet<Entities.Item> Items { get; set; }
    }
}

