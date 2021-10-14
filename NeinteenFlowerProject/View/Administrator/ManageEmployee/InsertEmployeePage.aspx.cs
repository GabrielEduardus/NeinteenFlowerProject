using NeinteenFlowerProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View.AdminPage.ManageEmployee
{
    public partial class InsertEmployeePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Administrator";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            bool rbtnCowo = RadioButton1.Checked;
            bool rbtnCewe = RadioButton2.Checked;
            string address = addressTxt.Text;
            string phoneNum = phoneNumberTxt.Text.ToString();
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            string dob = ageTxt.Text;
            string salary = salaryTxt.Text;
            string posisition = "Employee";

            errorEmail.Text = EmployeeController.validateEmail(email);
            errorPassword.Text = EmployeeController.validatePassword(password);
            errorName.Text = EmployeeController.validateName(name);
            errorAge.Text = EmployeeController.validateAge(dob);
            errorGender.Text = EmployeeController.validateGender(rbtnCowo, rbtnCewe);
            errorPhoneNumber.Text = EmployeeController.validatePhone(phoneNum);
            errorAddress.Text = EmployeeController.validateAddress(address);
            errorSalary.Text = EmployeeController.validateSalary(salary);

            if (errorAddress.Text == "" && errorAge.Text == "" && errorEmail.Text == "" &&
                errorGender.Text == "" && errorName.Text == "" && errorPassword.Text == "" &&
                errorPhoneNumber.Text == "" && errorSalary.Text == "")
            {
                int tmpSalary = int.Parse(salary);
                string gender = EmployeeController.chkBoyOrGirl(rbtnCowo, rbtnCewe);
                DateTime tmpDob = DateTime.Parse(ageTxt.Text);
                EmployeeController.Insert(name, tmpDob, gender, address, phoneNum, email, tmpSalary,
                    password, posisition);
                Response.Redirect("~/View/Administrator/ManageEmployee/ManageEmployeePage.aspx");
            }
        }
    }
}