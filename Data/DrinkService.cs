using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsAndDrinks.Data
{
    public class DrinkService
    {
        private readonly ApplicationDbContext _db;

        public DrinkService(ApplicationDbContext db)
        {
            _db = db;
        }

        //for CRUD opertaion


        public List<DrinkInfo> GetDrink()
        {
            var drinkList = _db.DrinkInfos.ToList();
            return drinkList;
        }

        // Insert 
        public string CreateDrink(DrinkInfo objDrink)
        {
            _db.DrinkInfos.Add(objDrink);
            _db.SaveChanges();
            return "Save Successfully";
        }
        public DrinkInfo GetDrinkById(int id)
        {
            DrinkInfo drink = _db.DrinkInfos.FirstOrDefault(s => s.DrinkId == id);
            return drink;
        }

        //Update 
        public string UpdateDrink(DrinkInfo objDrink)
        {
            _db.DrinkInfos.Update(objDrink);
            _db.SaveChanges();
            return "Update Successfully";
        }

        //Delete 
        public string DeleteDrinkInfo(DrinkInfo objDrink)
        {
            _db.Remove(objDrink);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
