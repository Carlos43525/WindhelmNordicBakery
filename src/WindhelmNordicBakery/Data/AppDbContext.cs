using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WindhelmNordicBakery.Models;

namespace WindhelmNordicBakery.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed category
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Gifts" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Breads" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Cakes" });

            // seed products
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1, 
                Name = "Cookbook", 
                ShortDescription = "Our legendary recipe book!", 
                LongDescription = "Detailed instructions to bring many of our legendary goods home to your kitchen!", 
                AllergyInformation = "", 
                Price = 24.99M, 
                ImageFile = "cookbook.jpg", 
                ImageThumbnailFile = "cookbook.jpg", 
                Popularity = 0, 
                InStock = true, 
                CategoryId = 1, 
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Sourdough",
                Price = 4.99M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = " Curabitur ullamcorper nulla non enim hendrerit aliquam. Aenean luctus viverra ante a placerat. Nam mollis consectetur varius. Sed eleifend facilisis viverra. Mauris in urna eget mi ullamcorper elementum. Mauris ultrices ante mauris, at congue dui pulvinar faucibus. Nunc eget est a sem blandit placerat quis quis nisl. Nullam condimentum quis eros blandit rutrum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec et libero nec enim sodales fermentum at a libero.", 
                ImageFile = "sourdough.jpg",
                ImageThumbnailFile = "sourdough.jpg",
                Popularity = 0,
                InStock = true, 
                CategoryId = 2
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Viking Rye Bread",
                Price = 2.99M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = " Curabitur ullamcorper nulla non enim hendrerit aliquam. Aenean luctus viverra ante a placerat. Nam mollis consectetur varius. Sed eleifend facilisis viverra. Mauris in urna eget mi ullamcorper elementum. Mauris ultrices ante mauris, at congue dui pulvinar faucibus. Nunc eget est a sem blandit placerat quis quis nisl. Nullam condimentum quis eros blandit rutrum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec et libero nec enim sodales fermentum at a libero.",
                ImageFile = "VikingRye.jpg",
                ImageThumbnailFile = "VikingRye.jpg",
                Popularity = 1,
                InStock = true,
                CategoryId = 2
            });
        }
    }
}
