using NeinteenFlowerProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Guest";
            UserController.authenticationForAll(Response, Session, current);

            if (!IsPostBack)
            {
                captchaLbl.Text = UserLoginController.createCaptcha();
            }
        }

        protected void ForgotPasswordBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string captcha = captchaLbl.Text;
            string inputCaptcha = captchaTxt.Text;
            string newPassword = NewPasswordTxt.Text;

            errorEmail.Text = UserLoginController.validateEmail(email);
            errorCaptcha.Text = UserLoginController.validateCaptcha(inputCaptcha, captcha);
            errorNewPassword.Text = UserLoginController.validateCaptcha(newPassword, captcha);

            if (errorEmail.Text == "" || errorCaptcha.Text == "" || errorNewPassword.Text == "")
            {
                errorForgotPassword.Text = UserLoginController.updatePassword(email, newPassword);
            }
        }
    }
}