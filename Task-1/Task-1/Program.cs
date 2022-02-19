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
                username = Console.ReadLine();
                password = Console.ReadLine();
                Admin admin = new Admin(username, password, true ,Console.ReadLine());
                //Console.WriteLine(admin.FirstHalf());
                //Console.WriteLine(admin.SecondHalf());
                Console.WriteLine(admin.GetAll());
            } while (!Admin.isCorrect(username,password));                               
        }                                            
    }
}
