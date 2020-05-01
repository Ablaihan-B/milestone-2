using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Ablaihan.Models;
using Project_Ablaihan.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Project_Ablaihan.Controllers
{
    public class UsersController : Controller
    {

      
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var connectionString = configuration.GetConnectionString("GoodsDatabase");

            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<UserContext>().UseSqlite(connection).Options;

            using (UserContext db = new UserContext(options))
            {
                //User user1 = new User { Id = "1", Name = "Ablai", Surname = "Bexeit", Login = "able777", Password = "777" };

                string name = user.Name;
                string surname = user.Surname;
                string login = user.Login;
                string password = user.Password;
                string id = Char.ToString(login[1]) + name[0] + name[1] + surname[0] + surname[1];
                string idd = "hi" + id;

                User us = new User{Id = "hi", Name = name, Surname = surname, Login = login, Password = password };

                db.Users.Add(us);
                db.SaveChanges();

            }

            return View(user);
        }
    }
}