using NeinteenFlowerProject.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace NeinteenFlowerProject.Controller
{
    public class TransactionController
    {
        public static void insertTransaction(int memberId, int quantity, int flowerId)
        {
            TransactionHandler.insertTransaction(memberId, quantity, flowerId);
        }

    }
}