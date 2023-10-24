using Microsoft.EntityFrameworkCore;

using ShopApplication.Models;

namespace ShopApplication.Entity
{
    public class ApplicationDbContext : DbContext
    {

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductReceipt> ProductReceipt { get; set; }
        public DbSet<ProductTransfer> ProductTransfer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Products>().ToTable("Products").HasMany(e => e.ProductReceipt).WithOne(e => e.Products).HasForeignKey(e => e.ProductId).IsRequired();
            modelBuilder.Entity<Products>().ToTable("Products").HasMany(e => e.productTransfers).WithOne(e => e.Products).HasForeignKey(e => e.ProductId).IsRequired();
            modelBuilder.Entity<Products>().ToTable("Products").HasOne(e => e.ProductCategory).WithMany(e => e.Products).HasForeignKey(e => e.ProductCategoryId).IsRequired();
            modelBuilder.Entity<ProductReceipt>().ToTable("ProductReceipts").HasOne(e => e.Products).WithMany(e => e.ProductReceipt).HasForeignKey(e => e.ProductId).IsRequired();
            modelBuilder.Entity<ProductTransfer>().ToTable("ProductTransfers").HasOne(e => e.Products).WithMany(e => e.productTransfers).HasForeignKey(e => e.ProductId).IsRequired();
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategories").HasMany(e => e.Products).WithOne(e => e.ProductCategory).HasForeignKey(e => e.ProductCategoryId).IsRequired();

            for (int i = 0; i < 20; i++)
            {
                modelBuilder.Entity<User>().HasData(new User()


                {
                    Id = Guid.NewGuid(),
                    Name = RandomString(4),
                    Email = RandomString(8) + "@gmail.com",
                    Password = RandomString(10),
                }
                    );

            }



            for (int i = 0; i < 10; i++)
            {
                modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory()


                {
                    Id = Guid.NewGuid(),
                    Name = RandomString(4),
                    categorycode = RandomString(8),
                }
                    );

            }
        }
    }
}
