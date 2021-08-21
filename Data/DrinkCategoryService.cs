using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsAndDrinks.Data
{
    public class DrinkCategoryService
    {
        private readonly ApplicationDbContext _db;

        public DrinkCategoryService(ApplicationDbContext db)
        {
            _db = db;
        }

        //for CRUD opertaion

        public List<DrinkCategoryInfo> GetDrinkCategory()
        {
            var drinkcategorylist = _db.DrinkCategoryInfos.ToList();
            return drinkcategorylist;
        }

        // Insert 
        public string CreateDrinkCategory(DrinkCategoryInfo objDrinkCategory)
        {
            _db.DrinkCategoryInfos.Add(objDrinkCategory);
            _db.SaveChanges();
            return "Save Successfully";
        }

       
        public DrinkCategoryInfo GetDrinkCategoryById(int id)
        {
            DrinkCategoryInfo drinkcategory = _db.DrinkCategoryInfos.FirstOrDefault(s => s.DrinkCategoryId == id);
            return drinkcategory;
        }

        //Update 
        public string UpdateDrinkCategory(DrinkCategoryInfo objDrinkCategory)
        {
            _db.DrinkCategoryInfos.Update(objDrinkCategory);
            _db.SaveChanges();
            return "Update Successfully";
        }

        //Delete 
        public string DeleteDrinkCategoryInfo(DrinkCategoryInfo objDrinkCategory)
        {
            _db.Remove(objDrinkCategory);
            _db.SaveChanges();
            return "Delete Successfully";
        }


    }
}
