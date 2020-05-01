using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using Project_Ablaihan.Models.Categories;
using Project_Ablaihan.Models.Goods;
using Project_Ablaihan.Models.Comments;


namespace Project_Ablaihan.Models.Users
{
    public class User
    {
  

        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Login")]
        public string Login { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

    }
}
