using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsAndDrinks.Data
{
    public class RegionService
    {
        private readonly ApplicationDbContext _db;

        public RegionService(ApplicationDbContext db)
        {
            _db = db;
        }

        //for CRUD opertaion

        public List<RegionInfo> GetRegion()
        {
            var regionlist = _db.RegionInfos.ToList();
            return regionlist;
        }

        // Insert 
        public string CreateRegion(RegionInfo objRegion)
        {
            _db.RegionInfos.Add(objRegion);
            _db.SaveChanges();
            return "Save Successfully";
        }

        public RegionInfo GetRegionById(int id)
        {
            RegionInfo region = _db.RegionInfos.FirstOrDefault(s => s.RegionId == id);
            return region;
        }

        //Update 
        public string UpdateRegion(RegionInfo objRegion)
        {
            _db.RegionInfos.Update(objRegion);
            _db.SaveChanges();
            return "Update Successfully";
        }

        //Delete 
        public string DeleteRegionInfo(RegionInfo objRegion)
        {
            _db.Remove(objRegion);
            _db.SaveChanges();
            return "Delete Successfully";
        }


    }
}
