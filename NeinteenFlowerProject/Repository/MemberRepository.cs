using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Repository
{
    public class MemberRepository
    {
        public static MsMember GetMemberByID(int id)
        {
            NFDBEntities db = new NFDBEntities();
            MsMember member = db.MsMembers.Find(id);
            return member;
        }
        public static List<MsMember> getAllMember()
        {
            NFDBEntities db = new NFDBEntities();
            return db.MsMembers.ToList();
        }

        public static void insertMember(MsMember mm)
        {
            NFDBEntities db = new NFDBEntities();
            db.MsMembers.Add(mm);
            db.SaveChanges();
        }

        public static void updateMember(int id, string name, DateTime dob, string gender, string address,
            string phoneNum, string email, string password)
        {
            NFDBEntities db = new NFDBEntities();
            MsMember mm = db.MsMembers.Find(id);
            mm.MemberName = name;
            mm.MemberDOB = dob;
            mm.MemberGender = gender;
            mm.MemberAddress = address;
            mm.MemberPhone = phoneNum;
            mm.MemberEmail = email;
            mm.MemberPassword = password;
            db.SaveChanges();
        }

        public static void deleteMember(int id)
        {
            NFDBEntities db = new NFDBEntities();
            MsMember mm = db.MsMembers.Find(id);
            db.MsMembers.Remove(mm);
            db.SaveChanges();
        }

        public static MsMember getMemberbyEmail(string email)
        {
            NFDBEntities db = new NFDBEntities();
            return (from x in db.MsMembers where x.MemberEmail.Equals(email) select x).FirstOrDefault();
        }

        public static void updatePassword(string email, string password)
        {
            NFDBEntities db = new NFDBEntities();
            MsMember mm = (from x in db.MsMembers where x.MemberEmail.Equals(email) select x).FirstOrDefault();
            mm.MemberPassword = password;

            db.SaveChanges();
        }
    }
}