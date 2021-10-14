using NeinteenFlowerProject.Dataset;
using NeinteenFlowerProject.Handler;
using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Controller
{
    public class DatasetController
    {
        public static FlowerDataset getDataset()
        {
            FlowerDataset dataset = new FlowerDataset();
            List<TrHeader> trHeaders = TransactionHandler.getTransactions();

            var header = dataset.Transaction_Header;
            var detail = dataset.Transactions_Detail;

            foreach(TrHeader tran in trHeaders)
            {
                DataRow headerRow = header.NewRow();
                //masukin data kedalam headeRow
                headerRow["ID"] = tran.TransactionID;
                headerRow["Member Name"] = tran.MsMember.MemberName;
                headerRow["Transaction Date"] = tran.TransactionDate;
                headerRow["Grand Total"] = tran.TrDetails.Sum(x => x.Quantity * x.MsFlower.FlowerPrice);

                header.Rows.Add(headerRow);

                foreach(TrDetail det in tran.TrDetails)
                {
                    DataRow detailRow = detail.NewRow();

                    detailRow["ID"] = det.TransactionID;
                    detailRow["Transaction ID"] = tran.TransactionID;
                    detailRow["Flower Name"] = det.MsFlower.FlowerName;
                    detailRow["Quantity"] = det.Quantity;
                    detailRow["Price"] = det.MsFlower.FlowerPrice;
                    detailRow["Sub Total"] = det.MsFlower.FlowerPrice * det.Quantity;

                    detail.Rows.Add(detailRow);
                }
            }

            return dataset;
        }
    }
}