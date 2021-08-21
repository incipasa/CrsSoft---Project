using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FoodsAndDrinks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<FoodInfo> FoodInfos { get; set; }
        public DbSet<CategoryInfo> CategoryInfos { get; set; }
        public DbSet<RegionInfo> RegionInfos { get; set; }
        public DbSet<DrinkInfo> DrinkInfos { get; set; }
        public DbSet<DrinkCategoryInfo> DrinkCategoryInfos { get; set; }
        public DbSet<DrinkRegionInfo> DrinkRegionInfos { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }*/

    }

}