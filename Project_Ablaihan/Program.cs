using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Project_Ablaihan.Models;
using Project_Ablaihan.Models.Users;

namespace Project_Ablaihan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            using(UserContext db = new UserContext())
            {
                User user1 = new User { Id = "1",Name = "Ablai", Surname ="Bexeit",Login="able777",Password="777"};
                
                db.Users.Add(user1);
                db.SaveChanges();

            }
            */
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
