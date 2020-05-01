using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Ablaihan.Models;
using Project_Ablaihan.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Project_Ablaihan.Controllers
{
    public class CategoriesController : Controller
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
            using (UserContext db = new UserContext())
            {
                //User user1 = new User { Id = "1", Name = "Ablai", Surname = "Bexeit", Login = "able777", Password = "777" };

                db.Users.Add(user);
                db.SaveChanges();

            }

            return View("Index",user);
        }

        /*
        public IActionResult Search(string text)
        {
            text = text.ToLower();
            var searchedMovies = movies.Where(movie => movie.Name.ToLower().Contains(text)
                                            || movie.Genre.ToLower().Contains(text)
                                            || movie.Author.ToLower().Contains(text))
                                        .ToList();
            return View("Index", searchedMovies);
        }
        */


    }
}