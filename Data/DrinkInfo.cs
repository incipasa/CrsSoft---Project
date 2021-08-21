using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;


namespace FoodsAndDrinks.Data
{
    public class DrinkInfo : IComparable<DrinkInfo>
    {
        [Key]
        public int DrinkId { get; set; }
        [Required]
        public string DrinkName { get; set; }
        [Required]
        public string DrinkRecipe { get; set; }
        [Required]
        public string DrinkIngredient { get; set; }

        [Required]
        public int DrinkCategoryId { get; set; }
        [ForeignKey("DrinkCategoryId")]
        public DrinkCategoryInfo DrinkCategoryInfo { get; set; }

        [Required]
        public int DrinkRegionId { get; set; }
        [ForeignKey("DrinkRegionId")]
        public DrinkRegionInfo DrinkRegionInfo { get; set; }

        public int CompareTo([AllowNull] DrinkInfo other)
        {
            throw new NotImplementedException();
        }
    }

    public class SortByDrinkCategory : IComparer<DrinkInfo>
    {
        public int Compare([AllowNull] DrinkInfo x, [AllowNull] DrinkInfo y)
        {
            return x.DrinkCategoryId.CompareTo(y.DrinkCategoryId);
            throw new NotImplementedException();
        }
    }
    public class SortByDrinkRegion : IComparer<DrinkInfo>
    {
        public int Compare([AllowNull] DrinkInfo x, [AllowNull] DrinkInfo y)
        {
            return x.DrinkRegionId.CompareTo(y.DrinkRegionId);
            throw new NotImplementedException();
        }
    }

}
