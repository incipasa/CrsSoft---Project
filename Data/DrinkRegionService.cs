using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsAndDrinks.Data
{
    public class DrinkRegionService
    {
        private readonly ApplicationDbContext _db;

        public DrinkRegionService(ApplicationDbContext db)
        {
            _db = db;
        }

        //for CRUD opertaion

        public List<DrinkRegionInfo> GetDrinkRegion()
        {
            var drinkregionlist = _db.DrinkRegionInfos.ToList();
            return drinkregionlist;
        }

        // Insert
        public string CreateDrinkRegion(DrinkRegionInfo objDrinkRegion)
        {
            _db.DrinkRegionInfos.Add(objDrinkRegion);
            _db.SaveChanges();
            return "Save Successfully";
        }
        public DrinkRegionInfo GetDrinkRegionById(int id)
        {
            DrinkRegionInfo drinkregion = _db.DrinkRegionInfos.FirstOrDefault(s => s.DrinkRegionId == id);
            return drinkregion;
        }

        //Update 
        public string UpdateDrinkRegion(DrinkRegionInfo objDrinkRegion)
        {
            _db.DrinkRegionInfos.Update(objDrinkRegion);
            _db.SaveChanges();
            return "Update Successfully";
        }

        //Delete 
        public string DeleteDrinkRegionInfo(DrinkRegionInfo objDrinkRegion)
        {
            _db.Remove(objDrinkRegion);
            _db.SaveChanges();
            return "Delete Successfully";
        }


    }
}
