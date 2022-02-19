using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;

            do
            {
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                if (Admin.CheckIfTrue(username,password))
                {
                    Admin admin = new Admin(username, password, true, "Admin Settings");
                    Console.WriteLine(admin.GetAll());
                }
                else
                {
                    Console.WriteLine("Username needs to be longer than 6, lesser than 30 characters\nPassword needs to at least have 1 uppercase, 1 digit and more than 8 characters");
                }
            } while (!Admin.CheckIfTrue(username,password));                              
        }                                            
    }
}
