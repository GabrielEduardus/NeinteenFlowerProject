using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NeinteenFlowerProject.Controller;

namespace NeinteenFlowerProject.View
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HomeBtn.Visible = false;
            LogoutBtn.Visible = false;
            if(Session["Userlogin"] != null)
            {
                HomeBtn.Visible = true;
                LogoutBtn.Visible = true;
            }
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            UserController.removeCookieAndSession(Response, Session);
            Response.Redirect("~/View/Guest/Login.aspx");
        }
    }
}