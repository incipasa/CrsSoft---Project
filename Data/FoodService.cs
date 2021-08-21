using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsAndDrinks.Data
{
    public class FoodService
    {
        private readonly ApplicationDbContext _db;

        public FoodService(ApplicationDbContext db)
        {
            _db = db;
        }

        //for CRUD opertaion


        public List<FoodInfo> GetFood()
        {
            var foodList = _db.FoodInfos.ToList();
            return foodList;
        }


        // Insert 
        public string Create(FoodInfo objFood)
        {
            _db.FoodInfos.Add(objFood);
            _db.SaveChanges();
            return "Save Successfully";
        }
        public FoodInfo GetFoodById(int id)
        {
            FoodInfo food = _db.FoodInfos.FirstOrDefault(s => s.FoodId == id);
            return food;
        }

        //Update 
        public string UpdateFood(FoodInfo objFood)
        {
            _db.FoodInfos.Update(objFood);
            _db.SaveChanges();
            return "Update Successfully";
        }

        //Delete 
        public string DeleteFoodInfo(FoodInfo objFood)
        {
            _db.Remove(objFood);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }

}
