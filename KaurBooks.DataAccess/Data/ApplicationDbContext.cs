using KaurBooks.DataAccess.Migrations;
using KaurBooks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmandeepKBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        
<<<<<<< HEAD
        public DbSet<Product> Products { get; set; }          // adding products to DB
=======
     ///   public DbSet<Product> Products { get; set; }          // adding products to DB
>>>>>>> d4ee44d8d860d6acd668629e1be7d4fc91fe9837
    }
}
