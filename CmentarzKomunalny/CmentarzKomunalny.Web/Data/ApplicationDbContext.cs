﻿using CmentarzKomunalny.Web.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CmentarzKomunalny.Web.Data
{
    //  public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(
            DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // fluent API commands
      //      modelBuilder.Entity<ApplicationUser>()
      //          .ToTable("AspNetUsers")
      //          .HasDiscriminator<int>("UserType")
      //          .HasValue<Employee>((int)RoleValue.Employee);
                
        }

    }
}
