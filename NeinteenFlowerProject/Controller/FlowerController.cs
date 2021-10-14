using NeinteenFlowerProject.Handler;
using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Controller
{
    public class FlowerController
    {

        public static MsFlower GetFlowerByID(int id)
        {
            MsFlower flower = FlowerHandler.GetFlowerByID(id);
            return flower;
        }

        public static List<MsFlower> GetAllFlower()
        {
            return FlowerHandler.GetAllFlower();
        }

        public static string validateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "Name must be filled!";
            if (name.Length < 5) return "Name must be at least 5 characters";
            else return "";
        }

        public static string validateImg(string extention)
        {
            if (!extention.Equals(".jpg")) return "Picture must be jpg!";
            else return "";
        }

        public static string validateDesc(string desc)
        {
            if (desc.Length < 50) return "Name must be at least 50 characters";
            return "";
        }

        public static string validateType(int selectedType)
        {
            if (selectedType == 0) return "Please select the type!";
            return "";
        }

        public static string validatePrice(int price)
        {

            if (price < 20 || price > 100) return "Flower price must be between 20 and 100!";
            return "";
        }

        public static void insert(string name, int selectedType, string description, int price, string image)
        {
            FlowerHandler.insert(name, selectedType, description, price, image);
        }


        public static void update(int id, string name, int selectedType, string description, int price, string image)
        {
            FlowerHandler.update(id, name, selectedType, description, price, image);
        }

        public static void delete(int id)
        {
            FlowerHandler.delete(id);
        }
    }
}