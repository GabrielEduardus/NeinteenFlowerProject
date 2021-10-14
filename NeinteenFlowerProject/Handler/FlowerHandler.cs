using NeinteenFlowerProject.Factory;
using NeinteenFlowerProject.Model;
using NeinteenFlowerProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Handler
{
    public class FlowerHandler
    {
        public static MsFlower GetFlowerByID(int id)
        {
            MsFlower flower = FlowerRepository.GetFlowerByID(id);
            return flower;
        }

        public static List<MsFlower> GetAllFlower()
        {
            return FlowerRepository.GetAllFlower();
        }

        public static void insert(string name, int type, string desc, int price, string image)
        {
            MsFlower toBeInserted = FlowerFactory.createFlower(name, type, desc, price, image);
            FlowerRepository.InsertFlower(toBeInserted);
        }

        
        public static void update(int id, string name, int type, string desc, int price, string image)
        {
            FlowerRepository.UpdateFlower(id, name, type, desc, price, image);
        }

        public static void delete (int id)
        {
            FlowerRepository.DeleteFlower(id);
        }


    }
}