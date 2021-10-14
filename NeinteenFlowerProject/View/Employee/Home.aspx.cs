using NeinteenFlowerProject.Controller;
using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View.Employee
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Employee";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);
            WelcomeLbl.Text = UserController.WelcomeLabel(Response, Session);
        }

        protected void manageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Employee/manageFlower.aspx");
        }
    }
}