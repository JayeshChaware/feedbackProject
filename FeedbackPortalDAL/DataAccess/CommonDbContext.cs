using FeedbackPortalDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeedbackPortalDAL.DataAccess
{
    public class CommonDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=IN-JAYESH;Initial Catalog=FeedbackPortal;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>()
                .HasOne<User>(s => s.User)
                .WithMany(g => g.Feedbacks)
                .HasForeignKey(s => s.UserId);
            /* modelBuilder.Entity<Question>()
                 .HasOne<User>(s => s.User)
                 .WithMany(g => g.Questions)
                 .HasForeignKey(s => s.UserId);

             modelBuilder.Entity<Answer>()
                 .HasOne<User>(s => s.User)
                 .WithMany(g => g.Answers)
                 .HasForeignKey(s => s.UserId);

             modelBuilder.Entity<Feedback>()
                 .HasOne<User>(s => s.User)
                 .WithMany(g => g.Feedbacks)
                 .HasForeignKey(s => s.UserId);

             modelBuilder.Entity<Product>()
                 .HasOne<User>(s => s.User)
                 .WithMany(g => g.Products)
                 .HasForeignKey(s => s.UserId);

             modelBuilder.Entity<Answer>()
                 .HasOne<Question>(s => s.Question)
                 .WithMany(g => g.Answers)
                 .HasForeignKey(s => s.QuestionId);

             modelBuilder.Entity<Feedback>()
                 .HasOne<Product>(s => s.Product)
                 .WithMany(g => g.Feedbacks)
                 .HasForeignKey(s => s.ProductId);

             modelBuilder.Entity<Product>()
                 .HasOne<ProductSubModel>(s => s.ProductSubModel)
                 .WithMany(g => g.Products)
                 .HasForeignKey(s => s.ProductSubModelId);

             modelBuilder.Entity<ProductSubModel>()
                 .HasOne<ProductModel>(s => s.ProductModel)
                 .WithMany(g => g.ProductSubModels)
                 .HasForeignKey(s => s.ProductModelId);


 */

        }
        public CommonDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set;}
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<ProductSubModel> ProductSubModels { get; set; }
        public DbSet<Question> Questions { get; set; }

    }
}
