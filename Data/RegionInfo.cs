using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FoodsAndDrinks.Data
{
    public class RegionInfo
    {
        [Key]
        public int RegionId { get; set; }
        [Required]
        public string RegionName { get; set; }

        public ICollection<FoodInfo> FoodInfos { get; set; }
    }

}
