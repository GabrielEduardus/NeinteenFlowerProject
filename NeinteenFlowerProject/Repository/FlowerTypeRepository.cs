using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Repository
{
    public class FlowerTypeRepository
    {
        public static void InsertFlowerType(MsFlowerType mft)
        {
            NFDBEntities db = new NFDBEntities();

            db.MsFlowerTypes.Add(mft);
            db.SaveChanges();
        }

        public static void DeleteFlowerType(int id)
        {
            NFDBEntities db = new NFDBEntities();

            MsFlowerType type = db.MsFlowerTypes.Find(id);
            db.MsFlowerTypes.Remove(type);
            db.SaveChanges();
        }

        public static List<MsFlowerType> GetAllFlowerType()
        {
            NFDBEntities db = new NFDBEntities();
            return db.MsFlowerTypes.ToList();
        }

        public static void UpdateFlowerType(int id, string typeName)
        {
            NFDBEntities db = new NFDBEntities();
            MsFlowerType mft = db.MsFlowerTypes.Find(id);
            mft.FlowerTypeName = typeName;
            db.SaveChanges();
        }
    }
}