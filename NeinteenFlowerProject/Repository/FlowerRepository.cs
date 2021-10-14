using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Repository
{
    public class FlowerRepository
    {
        public static void InsertFlower(MsFlower mf)
        {
            NFDBEntities db = new NFDBEntities();

            db.MsFlowers.Add(mf);
            db.SaveChanges();
        }

        public static void DeleteFlower(int id)
        {
            NFDBEntities db = new NFDBEntities();

            MsFlower flower = db.MsFlowers.Find(id);
            db.MsFlowers.Remove(flower);
            db.SaveChanges();
        }

        public static List<MsFlower> GetAllFlower()
        {
            NFDBEntities db = new NFDBEntities();
            return db.MsFlowers.ToList();
        }

        public static MsFlower GetFlowerByID(int id)
        {
            NFDBEntities db = new NFDBEntities();
            MsFlower flower = db.MsFlowers.Find(id);
            return flower;
        }

        public static void UpdateFlower(int id, string name, int typeId, string desc, int price, string image)
        {
            NFDBEntities db = new NFDBEntities();
            MsFlower mf = db.MsFlowers.Find(id);

            mf.FlowerName = name;
            mf.FlowerTypeID = typeId;
            mf.FlowerDescription = desc;
            mf.FlowerPrice = price;
            mf.FlowerImage = image;

            db.SaveChanges();

        }
    }
}