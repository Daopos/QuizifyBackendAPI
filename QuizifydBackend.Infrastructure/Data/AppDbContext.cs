using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizifydBackend.Domain.Models;
namespace QuizifydBackend.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //public DbSet<Blog> Blogs { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Blog>(builder =>
        //    {
        //        builder.Property(x => x.Title)
        //            .IsRequired();

        //        builder.Property(x => x.Description)
        //            .IsRequired();

        //        builder.Property(x => x.Category)
        //            .IsRequired();
        //    });

        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
