using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

using Project_Ablaihan.Models.Categories;
using Project_Ablaihan.Models.Goods;
using Project_Ablaihan.Models.Users;
using Project_Ablaihan.Models.Comments;

namespace Project_Ablaihan.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {
        }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         //   optionsBuilder.UseSqlite("Data Source = goods.db");
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database = Goods;Integrated Security = True");

        }
        */

        public ProductContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Good> Goods { get; set; }
        public DbSet<Category> Categories { get; set; }

    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ProductContext>
    {
        public ProductContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ProductContext>();

            var connectionString = configuration.GetConnectionString("GoodsDatabase");

            builder.UseSqlServer(connectionString);

            return new ProductContext(builder.Options);
        }
    }
}
