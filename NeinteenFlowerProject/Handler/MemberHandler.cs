using NeinteenFlowerProject.Factory;
using NeinteenFlowerProject.Model;
using NeinteenFlowerProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Handler
{
    public class MemberHandler
    {
        public static MsMember GetMemberByID(int id)
        {
            MsMember member = MemberRepository.GetMemberByID(id);
            return member;
        }
        public static List<MsMember> GetAllMember()
        {
            return MemberRepository.getAllMember();
        }

        public static bool UniqueEmail(string email)
        {
            MsEmployee me = EmployeeRepository.getEmployeebyEmail(email);
            MsMember mm = MemberRepository.getMemberbyEmail(email);
            if (me != null || mm != null) return false;
            else return true;
        }

        public static bool UniqueEmailUpdate(string email)
        {
            MsEmployee me = EmployeeRepository.getEmployeebyEmail(email);
            MsMember mm = MemberRepository.getMemberbyEmail(email);
            if (me != null)
            {
                return false;
            }
            if (mm != null)
            {
                if (mm.MemberEmail == email)
                {
                    return true;
                }
                return false;
            }
            else return true;
        }

        public static void insert(string name, DateTime dob, string gender,
            string address, string phoneNumber, string email, string password)
        {
            MsMember toBeInserted = MemberFactory.insertMember(name, dob, gender, address, phoneNumber,
                email, password);
            MemberRepository.insertMember(toBeInserted);
        }

        public static void update(int id, string name, DateTime dob, string gender,
            string address, string phoneNumber, string email, string password)
        {
            MemberRepository.updateMember(id, name, dob, gender, address, phoneNumber,
                email, password);
        }

        public static void delete(int id)
        {
            MemberRepository.deleteMember(id);
        }
    }
}