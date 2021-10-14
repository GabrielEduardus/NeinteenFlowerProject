using NeinteenFlowerProject.Controller;
using NeinteenFlowerProject.Model;
using NeinteenFlowerProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Guest";
            UserController.authenticationForAll(Response, Session, current);

            HttpCookie reqCookie = Request.Cookies.Get("UserInfo");
            
            if (reqCookie != null)
            {
                string emailFromCookie = reqCookie.Value;
                string role = UserController.checkRole(emailFromCookie);

                if (role == "Member")
                {
                    MsMember mm = UserController.getMemberbyEmail(emailFromCookie);
                    emailTxt.Text = mm.MemberEmail;
                    passwordTxt.Attributes.Add("value", mm.MemberPassword);
                }
                else
                {
                    MsEmployee me = UserController.getEmployeebyEmail(emailFromCookie);
                    emailTxt.Text = me.EmployeeEmail;
                    passwordTxt.Attributes.Add("value", me.EmployeePassword);
                }
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            bool isChecked = RememberMeCheck.Checked;

            errorEmail.Text = UserLoginController.validateEmail(email);
            errorPassword.Text = UserLoginController.validatePassword(email, password);

            if (errorEmail.Text == "" && errorPassword.Text == "")
            {
                UserController.RememberMeCookie(Response, isChecked, email);

                UserController.createSession(Session, email);

                errorLogin.Text = "Login Success";

                Response.Redirect("~/View/" + UserLoginController.loginUser(email) + "/Home.aspx");
            }
        }
    }
}