using MyWebLapTop.Data.Entities;
using MyWebLapTop.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebLapTop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of MyWebLapTop" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of MyWebLapTop" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of MyWebLapTop" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Máy tính xác tay", LanguageId = "vi", SeoAlias = "may-tinh-xac-tay", SeoDescription = "Máy tính xác tay các loại", SeoTitle = "Máy tính xác tay các loại" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Laptop", LanguageId = "en", SeoAlias = "laptop", SeoDescription = "laptops of all kinds", SeoTitle = "laptops of all kinds" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Phụ kiện", LanguageId = "vi", SeoAlias = "phu-kien", SeoDescription = "Phụ kiện các loại", SeoTitle = "Phụ kiện các loại" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Accessories", LanguageId = "en", SeoAlias = "accessories", SeoDescription = "Accessories of all kinds", SeoTitle = "accessories of all kinds" }
                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,
               OriginalPrice = 38989000,
               Price = 42499000,
               Stock = 0,
               ViewCount = 0,
           });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Laptop LG Gram 17Z90N-V.AH75A5",
                     LanguageId = "vi",
                     SeoAlias = "laptop-lg-gram-17Z90n-v-ah75A5",
                     SeoDescription = "Laptop LG Gram 17Z90N-V.AH75A5",
                     SeoTitle = "Laptop LG Gram 17Z90N-V.AH75A5",
                     Details = "Laptop LG Gram 17Z90N-V.AH75A5",
                     Description = "Laptop LG Gram 17Z90N-V.AH75A5"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Laptop LG Gram 17Z90N-V.AH75A5",
                        LanguageId = "en",
                        SeoAlias = "laptop-lg-gram-17Z90n-v-ah75A5",
                        SeoDescription = "Laptop LG Gram 17Z90N-V.AH75A5",
                        SeoTitle = "Laptop LG Gram 17Z90N-V.AH75A5",
                        Details = "Laptop LG Gram 17Z90N-V.AH75A5",
                        Description = "Laptop LG Gram 17Z90N-V.AH75A5"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "minhtrungxyz123@gmail.com",
                NormalizedEmail = "minhtrungxyz123@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Trung",
                LastName = "Phạm",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<Slide>().HasData(
              new Slide() { Id = 1, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 1, Url = "#", Image = "/themes/images/carousel/1pc.png", Status = Status.Active },
              new Slide() { Id = 2, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 2, Url = "#", Image = "/themes/images/carousel/2.jpg", Status = Status.Active },
              new Slide() { Id = 3, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 3, Url = "#", Image = "/themes/images/carousel/3pc.png", Status = Status.Active },
              new Slide() { Id = 4, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 4, Url = "#", Image = "/themes/images/carousel/4pc.png", Status = Status.Active },
              new Slide() { Id = 5, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 5, Url = "#", Image = "/themes/images/carousel/5pc.png", Status = Status.Active },
              new Slide() { Id = 6, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 6, Url = "#", Image = "/themes/images/carousel/6pc.png", Status = Status.Active }
              );
        }
    }
}