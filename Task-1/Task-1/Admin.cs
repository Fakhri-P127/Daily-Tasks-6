using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;
        
        public Admin(string username, string password, bool issuperadmin, string section):base(username,password)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
        }       
        public override string GetAll()
        {
            return base.GetAll() + $"\nIsSuperAdmin: {IsSuperAdmin}\nSection: {Section}\n";
        }
    }
}
