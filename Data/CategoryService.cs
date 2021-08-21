using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsAndDrinks.Data
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _db;

        public CategoryService(ApplicationDbContext db)
        {
            _db = db;
        }

        //for CRUD opertaion


        public List<CategoryInfo> GetCategory()
        {
            var categorylist = _db.CategoryInfos.ToList();
            return categorylist;
        }

        public string CreateCategory(CategoryInfo objCategory)
        {
            _db.CategoryInfos.Add(objCategory);
            _db.SaveChanges();
            return "Save Successfully";
        }

        public CategoryInfo GetCategoryById(int id)
        {
            CategoryInfo category = _db.CategoryInfos.FirstOrDefault(s => s.CategoryId == id);
            return category;
        }

        //Update 
        public string UpdateCategory(CategoryInfo objCategory)
        {
            _db.CategoryInfos.Update(objCategory);
            _db.SaveChanges();
            return "Update Successfully";
        }

        //Delete 
        public string DeleteCategoryInfo(CategoryInfo objCategory)
        {
            _db.Remove(objCategory);
            _db.SaveChanges();
            return "Delete Successfully";
        }


    }
}
