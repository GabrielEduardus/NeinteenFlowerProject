using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Factory
{
    public class TransactionDetailFactory
    {
        public static TrDetail insertTransaction(int quantity, int flowerId, int tranId)
        {
            TrDetail td = new TrDetail();
            td.FlowerID = flowerId;
            td.Quantity = quantity;
            td.TransactionID = tranId;

            return td;
        }
    }
}