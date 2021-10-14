using NeinteenFlowerProject.Factory;
using NeinteenFlowerProject.Model;
using NeinteenFlowerProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace NeinteenFlowerProject.Handler
{
    public class TransactionHandler
    {
        public static List<TrHeader> getTransactions()
        {
            return TransactionRepository.getTransactions();
        }

        public static void insertTransaction(int memberId, int quantity, int flowerId)
        {
            TrHeader tobeInsertedHeader = TransactionHeaderFactory.insertTransaction(memberId);
            TransactionRepository.insertTransactionHeader(tobeInsertedHeader);

            TrHeader header = TransactionRepository.getTransactionIdHeader();
            TrDetail tobeInsertedDetail = TransactionDetailFactory.insertTransaction(quantity, flowerId, header.TransactionID);
            TransactionRepository.insertTransactionDetail(tobeInsertedDetail);
        }
    }
}