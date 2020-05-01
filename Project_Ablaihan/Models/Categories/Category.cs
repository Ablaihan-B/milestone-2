using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using Project_Ablaihan.Models.Goods;



namespace Project_Ablaihan.Models.Categories
{
    public class Category
    {
        private int v1;
        private string v2;

        public Category(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

   
    }
}
