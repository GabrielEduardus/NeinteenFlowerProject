using NeinteenFlowerProject.Factory;
using NeinteenFlowerProject.Model;
using NeinteenFlowerProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Handler
{
    public class EmployeeHandler
    {
        public static MsEmployee GetEmployeeByID(int id)
        {
            MsEmployee e = EmployeeRepository.GetEmployeeByID(id);
            return e;
        }

        public static List<MsEmployee> GetAllEmployee()
        {
            return EmployeeRepository.getAllEmployee();
        }

        public static bool UniqueEmail(string email)
        {
            MsEmployee me1 = EmployeeRepository.getEmployeebyEmail(email);
            MsMember me2 = MemberRepository.getMemberbyEmail(email);
            if (me1 != null || me2 != null) return false;
            else return true;
        }

        public static bool UniqueEmailUpdate(string email)
        {
            MsEmployee me1 = EmployeeRepository.getEmployeebyEmail(email);
            MsMember me2 = MemberRepository.getMemberbyEmail(email);
            if (me1 != null)
            {
                if (me1.EmployeeEmail == email)
                {
                    return true;
                }
                return false;
            }
            if (me2 != null)
            {
                return false;
            }
            else return true;
        }

        public static void insert(string name, DateTime dob, string gender, string address,
            string phoneNum, string email, int salary, string password, string posisition)
        {
            MsEmployee toBeInserted = EmployeeFactory.insertEmployee(name, dob, gender, address, phoneNum, 
                email, salary, password, posisition);
            EmployeeRepository.insertEmployee(toBeInserted);
        }

        public static void update(int id, string name, DateTime dob, string gender, string address,
            string phoneNum, string email, int salary, string password)
        {
            EmployeeRepository.updateEmployee(id, name, dob, gender, address, phoneNum, email, salary, password);
        }

        public static void delete(int id)
        {
            EmployeeRepository.deleteEmployee(id);
        }
    }
}