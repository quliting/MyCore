using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Model;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Data
{
    public class UserContext : DbContext
    {

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<BPFile> BpFiles { get; set; }
        public DbSet<UserProperty> UserProperties { get; set; }
        public DbSet<UserTag> UserTags { get; set; }
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().ToTable("Users").HasKey(item => item.Id);
            modelBuilder.Entity<UserProperty>().ToTable("UserProperties").HasKey(item => new { item.AppUserId, item.Key, item.Value });
            modelBuilder.Entity<UserTag>().ToTable("UserTag").HasKey(item => new { item.UserId });

            modelBuilder.Entity<UserTag>().ToTable("UserTag").Property(item => item.Tag).HasMaxLength(100);
            modelBuilder.Entity<BPFile>().ToTable("UserBPFiles").HasKey(item =>new{ item.Id,item.UserId});


            base.OnModelCreating(modelBuilder);
        }
    }
}
