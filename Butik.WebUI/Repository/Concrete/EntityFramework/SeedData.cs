using Butik.WebUI.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Butik.WebUI.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices
                .GetRequiredService<ButikContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ ProductName="Desenli tisort", Price=50, Image="product1.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Desenli Tisort",DateAdded=DateTime.Now.AddDays(-10)},
                    new Product(){ ProductName="Kareli Bluz", Price=200,Image="product2.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Kareli Bluz",DateAdded=DateTime.Now.AddDays(-20)},
                    new Product(){ ProductName="Kısa etek", Price=100,Image="product3.jpg",IsHome=true,IsApproved=false,IsFeatured=true,Description="Kısa etek",HtmlContent="",DateAdded=DateTime.Now.AddDays(-5)},
                    new Product(){ ProductName="Yırtmaclı pantolon", Price=500, Image="product4.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Yırtmaclı pantolon",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Asimetrik Bluz", Price=60, Image="product5.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Asimetrik Bluz",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Kapsonlu Bluz", Price=50, Image="product6.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Kapsonlu Bluz",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Fırfırlı Bluz", Price=40, Image="product7.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Fırfırlı Bluz",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Kırmızı Bluz", Price=70, Image="product8.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Kırmızı Bluz",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Beyaz Tisort", Price=50, Image="product9.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Beyaz Tisort",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Cizgili Tisort", Price=40, Image="product10.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Cizgili Tisort",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Metallica Tisort", Price=65, Image="product11.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Metallica Tisort",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Basic Tisort", Price=50, Image="product12.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Basic Tisort",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Kırmızı Elbise", Price=120, Image="product13.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Kırmızı Elbise",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="İp Askılı Elbise", Price=140, Image="product14.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="İp Askılı Elbise",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Pembe Elbise", Price=120, Image="product15.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Pembe Elbise",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Asimetrik Kesim Elbise", Price=160, Image="product16.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Asimetrik Kesim Elbise",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Mini Kot Etek", Price=80, Image="product17.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Mini Kot Etek",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Pileli Etek", Price=100, Image="product18.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Pileli Etek",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Kemerli Etek", Price=120, Image="product19.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Kemerli Etek",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Keten Etek", Price=70, Image="product20.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Keten Etek",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Yırtık Pantolon", Price=120, Image="product21.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Yırtık Pantolon",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Kahverengi Pantolon", Price=140, Image="product22.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Kahverengi Pantolon",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Siyah Kot", Price=150, Image="product23.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Siyah Kot",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ ProductName="Beyaz Pantolon", Price=100, Image="product24.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Beyaz Pantolon",DateAdded=DateTime.Now.AddDays(-3)}




                };

                context.Products.AddRange(products);

                var categories = new[]
                {
                    new Category(){ CategoryName="Tisort"},
                    new Category(){ CategoryName="Bluz"},
                    new Category(){ CategoryName="Pantolon"},
                    new Category(){ CategoryName="Etek"},
                    new Category(){ CategoryName="Elbise"},
                };

                context.Categories.AddRange(categories);

                var productcategories = new[]
                {
                    new ProductCategory(){ Product=products[0],Category=categories[0]},
                    new ProductCategory(){ Product=products[1],Category=categories[1]},
                    new ProductCategory(){ Product=products[2],Category=categories[3]},
                    new ProductCategory(){ Product=products[3],Category=categories[2]},
                    new ProductCategory(){ Product=products[4],Category=categories[1]},
                    new ProductCategory(){ Product=products[5],Category=categories[1]},
                    new ProductCategory(){ Product=products[6],Category=categories[1]},
                    new ProductCategory(){ Product=products[7],Category=categories[1]},
                    new ProductCategory(){ Product=products[8],Category=categories[0]},
                    new ProductCategory(){ Product=products[9],Category=categories[0]},
                    new ProductCategory(){ Product=products[10],Category=categories[0]},
                    new ProductCategory(){ Product=products[11],Category=categories[0]},
                    new ProductCategory(){ Product=products[12],Category=categories[4]},
                    new ProductCategory(){ Product=products[13],Category=categories[4]},
                    new ProductCategory(){ Product=products[14],Category=categories[4]},
                    new ProductCategory(){ Product=products[15],Category=categories[4]},
                    new ProductCategory(){ Product=products[16],Category=categories[3]},
                    new ProductCategory(){ Product=products[17],Category=categories[3]},
                    new ProductCategory(){ Product=products[18],Category=categories[3]},
                    new ProductCategory(){ Product=products[19],Category=categories[3]},
                    new ProductCategory(){ Product=products[20],Category=categories[2]},
                    new ProductCategory(){ Product=products[21],Category=categories[2]},
                    new ProductCategory(){ Product=products[22],Category=categories[2]},
                    new ProductCategory(){ Product=products[23],Category=categories[2]}



                };

                context.AddRange(productcategories);

                var images = new[]
                {
                    new Image(){ImageName="product1.jpg",Product=products[0]},
                    new Image(){ImageName="product2.jpg",Product=products[1]},
                    new Image(){ImageName="product3.jpg",Product=products[2]},
                    new Image(){ImageName="product4.jpg",Product=products[3]},

                    new Image(){ImageName="product5.jpg",Product=products[4]},
                    new Image(){ImageName="product6.jpg",Product=products[5]},
                    new Image(){ImageName="product7.jpg",Product=products[6]},
                    new Image(){ImageName="product8.jpg",Product=products[7]},

                    new Image(){ImageName="product9.jpg",Product=products[8]},
                    new Image(){ImageName="product10.jpg",Product=products[9]},
                    new Image(){ImageName="product11.jpg",Product=products[10]},
                    new Image(){ImageName="product12.jpg",Product=products[11]},

                    new Image(){ImageName="product13.jpg",Product=products[12]},
                    new Image(){ImageName="product14.jpg",Product=products[13]},
                    new Image(){ImageName="product15.jpg",Product=products[14]},
                    new Image(){ImageName="product16.jpg",Product=products[15]},


                    new Image(){ImageName="product17.jpg",Product=products[16]},
                    new Image(){ImageName="product18.jpg",Product=products[17]},
                    new Image(){ImageName="product19.jpg",Product=products[18]},
                    new Image(){ImageName="product20.jpg",Product=products[19]},


                    new Image(){ImageName="product21.jpg",Product=products[20]},
                    new Image(){ImageName="product22.jpg",Product=products[21]},
                    new Image(){ImageName="product23.jpg",Product=products[22]},
                    new Image(){ImageName="product24.jpg",Product=products[23]},

                };

                context.Images.AddRange(images);

                var attributes = new[]
                {
                    new ProductAttribute(){Attribute="Beden",Value="S M L XL",Product=products[0]},
                    new ProductAttribute(){Attribute="Manken Boyu",Value="1.70",Product=products[0]},
                    new ProductAttribute(){Attribute="İade&Değişim",Value="14 gün içinde edilebilir",Product=products[0]},

                     new ProductAttribute(){Attribute="Beden",Value="S M L XL",Product=products[1]},
                    new ProductAttribute(){Attribute="Manken Boyu",Value="1.70",Product=products[1]},
                    new ProductAttribute(){Attribute="İade&Değişim",Value="14 gün içinde edilebilir",Product=products[1]},

                     new ProductAttribute(){Attribute="Beden",Value="S M L XL",Product=products[2]},
                    new ProductAttribute(){Attribute="Manken Boyu",Value="1.70",Product=products[2]},
                    new ProductAttribute(){Attribute="İade&Değişim",Value="14 gün içinde edilebilir",Product=products[2]},

                     new ProductAttribute(){Attribute="Beden",Value="S M L XL",Product=products[3]},
                    new ProductAttribute(){Attribute="Manken Boyu",Value="1.70",Product=products[3]},
                    new ProductAttribute(){Attribute="İade&Değişim",Value="14 gün içinde edilebilir",Product=products[3]},

                     new ProductAttribute(){Attribute="Beden",Value="S M L XL",Product=products[4]},
                    new ProductAttribute(){Attribute="Manken Boyu",Value="1.70",Product=products[4]},
                    new ProductAttribute(){Attribute="İade&Değişim",Value="14 gün içinde edilebilir",Product=products[4]},

                     new ProductAttribute(){Attribute="Beden",Value="S M L XL",Product=products[5]},
                    new ProductAttribute(){Attribute="Manken Boyu",Value="1.70",Product=products[5]},
                    new ProductAttribute(){Attribute="İade&Değişim",Value="14 gün içinde edilebilir",Product=products[5]},

                     new ProductAttribute(){Attribute="Beden",Value="S M L XL",Product=products[6]},
                    new ProductAttribute(){Attribute="Manken Boyu",Value="1.70",Product=products[6]},
                    new ProductAttribute(){Attribute="İade&Değişim",Value="14 gün içinde edilebilir",Product=products[6]},

                     new ProductAttribute(){Attribute="Beden",Value="S M L XL",Product=products[7]},
                    new ProductAttribute(){Attribute="Manken Boyu",Value="1.70",Product=products[7]},
                    new ProductAttribute(){Attribute="İade&Değişim",Value="14 gün içinde edilebilir",Product=products[7]},

                     new ProductAttribute(){Attribute="Beden",Value="S M L XL",Product=products[8]},
                    new ProductAttribute(){Attribute="Manken Boyu",Value="1.70",Product=products[8]},
                    new ProductAttribute(){Attribute="İade&Değişim",Value="14 gün içinde edilebilir",Product=products[8]},


                
                  
                
              




                };

                context.Attributes.AddRange(attributes);
                context.SaveChanges();

            }
        }

        internal static void CreateIdentityUsers(IServiceProvider applicationServices, IConfiguration configuration)
        {
            throw new NotImplementedException();
        }
    }
}
