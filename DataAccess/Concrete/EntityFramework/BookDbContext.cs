using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlamak
    public class BookDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //projenin hangi db ile ilişkili olduğunun belirtileceği yer
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\SQLEXPRESS;Database=book_library;Trusted_Connection=true"); //Ip numarası
                                                                                         //Trusted_Connection=true demek kullanıcı adı, şifre kontrol etmiyor demek                        
        }

        //veri tabanında hangi class hangi tabloya karşılık geliyor
        public DbSet<Product> Products { get; set; } 
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
