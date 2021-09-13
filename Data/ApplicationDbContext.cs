using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Website_challenge.Models;

namespace Website_challenge.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderFeature> OrderFeature { get; set; }
        public DbSet<OrderService> OrderService { get; set; }


        public DbSet<ServiceFeatures> ServiceFeaturess { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceFeatures>().HasKey(SF => new { SF.ServiceId, SF.FeatureId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
