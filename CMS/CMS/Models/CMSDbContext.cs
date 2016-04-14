using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CMS.Models
{
    public class CMSDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public CMSDbContext() : base("CMSDb", throwIfV1Schema: false) { }

        public static CMSDbContext Create()
        {
            return new CMSDbContext();
        }

        public IDbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Booking>().ToTable("Bookings");
        }
    }
}