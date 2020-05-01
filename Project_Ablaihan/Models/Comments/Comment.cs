using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


using Project_Ablaihan.Models.Categories;
using Project_Ablaihan.Models.Goods;
using Project_Ablaihan.Models.Users;


namespace Project_Ablaihan.Models.Comments
{
    public class Comment
    {
        public Comment(string v1, string v2, User us)
        {
        }

        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Text")]
        public string Text { get; set; }

        [Display(Name = "Author")]
        public User Author{ get; set; }

        public static implicit operator List<object>(Comment v)
        {
            throw new NotImplementedException();
        }
    }
}
