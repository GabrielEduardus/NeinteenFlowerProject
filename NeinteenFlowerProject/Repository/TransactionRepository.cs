using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Repository
{
    public class TransactionRepository
    {
        public static void insertTransactionHeader(TrHeader th)
        {
            NFDBEntities db = new NFDBEntities();
            db.TrHeaders.Add(th);
            db.SaveChanges();
        }

        public static void insertTransactionDetail(TrDetail td)
        {
            NFDBEntities db = new NFDBEntities();
            db.TrDetails.Add(td);
            db.SaveChanges();
        }

        public static List<TrHeader> getTransactions()
        {
            NFDBEntities db = new NFDBEntities();
            return (from x in db.TrHeaders select x).ToList();
        }

        public static TrHeader getTransactionIdHeader()
        {
            NFDBEntities db = new NFDBEntities();
            var testVar = (from x in db.TrHeaders select x).ToList();
            return testVar[testVar.Count-1];
        }
    }
}