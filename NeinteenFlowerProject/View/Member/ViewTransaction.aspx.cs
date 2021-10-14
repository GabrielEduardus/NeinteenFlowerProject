using NeinteenFlowerProject.Controller;
using NeinteenFlowerProject.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View.Member
{
    public partial class ViewTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Member";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);

            FlowerReport report = new FlowerReport();
            crv_report.ReportSource = report;
            report.SetDataSource(DatasetController.getDataset());
        }
    }
}