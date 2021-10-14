using NeinteenFlowerProject.Controller;
using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View.AdminPage.ManageEmployee
{
    public partial class UpdateEmployeePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Administrator";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);

            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                MsEmployee show = EmployeeController.GetEmployeeByID(id);
                emailTxt.Text = show.EmployeeEmail;
                passwordTxt.Text = show.EmployeePassword;
                nameTxt.Text = show.EmployeeName;
                if (show.EmployeeGender == "Male") RadioButton1.Checked = true;
                else RadioButton2.Checked = true;
                DateTime employeeDOB = (DateTime)show.EmployeeDOB;
                ageBefore.Text = employeeDOB.ToShortDateString();
                phoneNumberTxt.Text = show.EmployeePhone.ToString();
                addressTxt.Text = show.EmployeeAddress;
                salaryTxt.Text = show.EmployeeSalary.ToString();
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["id"]);
            MsEmployee show = EmployeeController.GetEmployeeByID(id);
            string name = nameTxt.Text;
            bool rbtnCowo = RadioButton1.Checked;
            bool rbtnCewe = RadioButton2.Checked;
            string address = addressTxt.Text;
            string phoneNum = phoneNumberTxt.Text.ToString();
            string emailTmp = show.EmployeeEmail;
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            string dob = ageTxt.Text;
            string salary = salaryTxt.Text;

            errorEmail.Text = EmployeeController.validateEmailUpdate(email);
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
                EmployeeController.Update(id, name, tmpDob, gender, address, phoneNum, email, tmpSalary, password);
                Response.Redirect("~/View/Administrator/ManageEmployee/ManageEmployeePage.aspx");
            }
        }
    }
}