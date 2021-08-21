using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FoodsAndDrinks.Data
{
    public class FoodInfo : IComparable<FoodInfo>
    {
        [Key]
        public int FoodId { get; set; }
        [Required]
        public string FoodName { get; set; }

        [Required]
        public string Recipe { get; set; }
        [Required]
        public string Ingredient { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual CategoryInfo CategoryInfo { get; set; }

        [Required]
        public int RegionId { get; set; }
        [ForeignKey("RegionId")]
        public virtual RegionInfo RegionInfo { get; set; }

        public int CompareTo([AllowNull] FoodInfo other)
        {
            throw new NotImplementedException();
        }
    }
    public class SortByCategory : IComparer<FoodInfo>
    {
        public int Compare([AllowNull] FoodInfo x, [AllowNull] FoodInfo y)
        {
            return x.CategoryId.CompareTo(y.CategoryId);    
            throw new NotImplementedException();
        }
    }
    public class SortByRegion : IComparer<FoodInfo>
    {
        public int Compare([AllowNull] FoodInfo x, [AllowNull] FoodInfo y)
        {
            return x.RegionId.CompareTo(y.RegionId);
            throw new NotImplementedException();
        }
    }

}
