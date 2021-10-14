using NeinteenFlowerProject.Controller;
using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View.Member
{
    public partial class Preorder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Member";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);
        }

        protected void preorderBtn_Click(object sender, EventArgs e)
        {
            int flowerId = int.Parse(Request["id"]);
            string quantity = quantityTxt.Text;
            MsMember mm = (MsMember)Session["Userlogin"];
            int memberId = mm.MemberID;

            errorQuantity.Text = MemberController.validateQuantity(quantity);

            if (errorQuantity.Text == "")
            {
                int tmpQuantity = int.Parse(quantity);
                TransactionController.insertTransaction(memberId, tmpQuantity, flowerId);
                Response.Redirect("~/View/Member/Home.aspx");
            }
        }
    }
}