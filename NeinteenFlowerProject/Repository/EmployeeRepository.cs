using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Repository
{
    public class EmployeeRepository
    {
        public static MsEmployee GetEmployeeByID(int id)
        {
            NFDBEntities db = new NFDBEntities();
            MsEmployee e = db.MsEmployees.Find(id);
            return e;
        }

        public static List<MsEmployee> getAllEmployee()
        {
            NFDBEntities db = new NFDBEntities();
            return db.MsEmployees.ToList();
        }

        public static void insertEmployee(MsEmployee me)
        {
            NFDBEntities db = new NFDBEntities();
            db.MsEmployees.Add(me);
            db.SaveChanges();
        }

        public static void updateEmployee(int id, string name, DateTime dob, string gender, string address,
            string phoneNum, string email, int salary, string password)
        {
            NFDBEntities db = new NFDBEntities();
            MsEmployee me = db.MsEmployees.Find(id);
            me.EmployeeName = name;
            me.EmployeeDOB = dob;
            me.EmployeeGender = gender;
            me.EmployeeAddress = address;
            me.EmployeePhone = phoneNum;
            me.EmployeeEmail = email;
            me.EmployeeSalary = salary;
            me.EmployeePassword = password;
            db.SaveChanges();
        }

        public static void deleteEmployee(int id)
        {
            NFDBEntities db = new NFDBEntities();
            MsEmployee me = db.MsEmployees.Find(id);
            db.MsEmployees.Remove(me);
            db.SaveChanges();
        }

        public static MsEmployee getEmployeebyEmail(string email)
        {
            NFDBEntities db = new NFDBEntities();
            return (from x in db.MsEmployees where x.EmployeeEmail.Equals(email) select x).FirstOrDefault();
        }

        public static void updatePassword(string email, string password)
        {
            NFDBEntities db = new NFDBEntities();
            MsEmployee me = (from x in db.MsEmployees where x.EmployeeEmail.Equals(email) select x).FirstOrDefault();
            me.EmployeePassword = password;

            db.SaveChanges();
        }
    }
}