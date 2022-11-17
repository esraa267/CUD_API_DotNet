using CRUD_Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Api.CRUD.EF.Data
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Product>? products { get; set; }
        public DbSet<Cart>? carts { get; set; }

        public DbSet<CartProduct>? CartProduct { get; set; }
        public DbSet<Items>? Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CartProduct>().HasKey(key => new { key.CartId, key.ProductId });

            builder.Entity<CartProduct>().HasOne<Product>().WithMany(item => item.CartProducts)
                .HasForeignKey(product => product.ProductId);

            builder.Entity<CartProduct>().HasOne<Cart>().WithMany(item => item.CartProducts)
           .HasForeignKey(product => product.CartId);

            base.OnModelCreating(builder);
        }
    }
}
