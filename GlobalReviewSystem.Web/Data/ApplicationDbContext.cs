using System;
using System.Collections.Generic;
using System.Text;
using GlobalReviewSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GlobalReviewSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Field>()
                .HasMany(f => f.Validators);

            builder.Entity<Validator>()
                .HasMany(f => f.Fields);
        }

        public DbSet<Advertiser> Advertisers { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Advertisement> Advertisements { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Field> Fields { get; set; }

        public DbSet<Form> Forms { get; set; }

        public DbSet<FormField> FormFields { get; set; }

        public DbSet<FormFieldValue> FormFieldValues { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<StateRegion> StateRegions { get; set; }

        public DbSet<Validator> Validators { get; set; }

        public DbSet<ValidatorProperty> ValidatorProperties { get; set; }
    }
}
