using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.SqlServer;


using Project_Ablaihan.Models.Categories;
using Project_Ablaihan.Models.Goods;
using Project_Ablaihan.Models.Users;
using Project_Ablaihan.Models.Comments;


namespace Project_Ablaihan.Models
{
    public class UserContext : DbContext
    {
        public UserContext()
        {
        }

        /*
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
   optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database = GoodsDatabase;Integrated Security = True");

}*/

        public UserContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
    

    }
}
