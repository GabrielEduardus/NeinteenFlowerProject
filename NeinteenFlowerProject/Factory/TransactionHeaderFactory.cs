using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Factory
{
    public class TransactionHeaderFactory
    {
        public static TrHeader insertTransaction(int memberId)
        {
            TrHeader th = new TrHeader();
            th.MemberID = memberId;

            th.EmployeeID = 9;

            th.TransactionDate = DateTime.Now;
            th.DiscountPercentage = 0;

            return th;
        }
    }
}