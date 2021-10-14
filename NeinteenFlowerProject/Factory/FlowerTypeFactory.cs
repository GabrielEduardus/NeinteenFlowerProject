using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Factory
{
    public class FlowerTypeFactory
    {
        public static MsFlowerType insertFlowerType(string flowerTypeName)
        {
            MsFlowerType mtt = new MsFlowerType();
            mtt.FlowerTypeName = flowerTypeName;

            return mtt;
        }
    }
}