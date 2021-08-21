using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FoodsAndDrinks.Data
{
    public class DrinkCategoryInfo
    {
        [Key]
        public int DrinkCategoryId { get; set; }
        [Required]
        public string DrinkCategoryName { get; set; }

        public ICollection<DrinkInfo> DrinkInfos { get; set; }
    }

}
