using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Factory
{
    public class FlowerFactory
    {
        public static MsFlower createFlower(string name, int type, string desc, int price, string image)
        {
            MsFlower mf = new MsFlower();
            mf.FlowerName = name;
            mf.FlowerTypeID = type;
            mf.FlowerDescription = desc;
            mf.FlowerPrice = price;
            mf.FlowerImage = image;

            return mf;
        }
    }
}