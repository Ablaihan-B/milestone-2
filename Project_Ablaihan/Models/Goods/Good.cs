using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using Project_Ablaihan.Models.Categories;
using Project_Ablaihan.Models.Comments;


namespace Project_Ablaihan.Models.Goods
{
    public class Good
    {
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Display(Name = "Characteristics")]
        public string Characteristics { get; set; }


        [Display(Name = "Category")]
        public Category Category{ get; set; }


        [Display(Name = "Comments")]
        public String Comments{ get; set; }



    }
}
