using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FoodsAndDrinks.Data
{
    public class DrinkRegionInfo
    {
        [Key]
        public int DrinkRegionId { get; set; }
        [Required]
        public string DrinkRegionName { get; set; }

        public ICollection<DrinkInfo> DrinkInfos { get; set; }
    }

}
