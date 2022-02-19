using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;
        
        //public Admin(string username, string password) : base(username, password)
        //{

        //}
        
        public Admin(string username, string password, bool issuperadmin, string section):base(username,password)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
        }
        //public string FirstHalf()
        //{

        //    return $"Username: {Username}\nPassword: {Password}";
        //}
        //public string SecondHalf()
        //{
        //    return $"\nIsSuperAdmin: {IsSuperAdmin}\nSection: {Section}";
        //}
        public override string GetAll()
        {
            return "\n"+base.GetAll() + $"\nIsSuperAdmin: {IsSuperAdmin}\nSection: {Section}";
        }

    }
}
