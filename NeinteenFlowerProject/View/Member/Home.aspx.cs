using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NeinteenFlowerProject.Controller;
using NeinteenFlowerProject.Model;

namespace NeinteenFlowerProject.View.Member
{
    public partial class Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Member";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);
            WelcomeLbl.Text = UserController.WelcomeLabel(Response, Session);

            var flowers = FlowerController.GetAllFlower();
            gvItem.DataSource = flowers;
            gvItem.DataBind();
        }

        protected void gvItem_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvItem.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text.ToString());

            Response.Redirect("~/View/Member/Preorder.aspx?id=" + id);
        }

        protected void viewTransactionBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Member/ViewTransaction.aspx");
        }
    }
}