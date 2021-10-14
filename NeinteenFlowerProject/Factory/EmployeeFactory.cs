using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Factory
{
    public class EmployeeFactory
    {
        public static MsEmployee insertEmployee(string name, DateTime dob, string gender, string address,
            string phoneNum, string email, int salary, string password, string posisition)
        {
            MsEmployee me = new MsEmployee();
            me.EmployeeName = name;
            me.EmployeeDOB = dob;
            me.EmployeeGender = gender;
            me.EmployeeAddress = address;
            me.EmployeePhone = phoneNum;
            me.EmployeeEmail = email;
            me.EmployeeSalary = salary;
            me.EmployeePassword = password;
            me.EmployeePosition = posisition;

            return me;
        }
    }
}