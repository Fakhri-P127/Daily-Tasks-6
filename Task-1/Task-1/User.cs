using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Task_1
{
    class User
    {       
        private string username;        
        public string Username
        { 
            get 
            {
                return username;
            }
            set
            {                
                if (value.Length > 6 && value.Length<30)
                {
                    username = value;                        
                }
                //else
                //{
                //    Console.WriteLine("Username needs to be longer than 6, lesser than 30 characters");                                             
                //}                                                             
            }            
        }
        private string password;
        public string Password
        {            
            get 
            {
                return password;
            }
            set
            {                
                if (value.Any(char.IsDigit) && value.Any(char.IsUpper) && value.Length>8)
                {
                    password = value;
                }

                #region For ile
                //bool hasUpper = false; bool hasDigit = false;
                //for (int i = 0; i < value.Length && !(hasUpper && hasDigit); i++)
                //{
                //    char index = value[i];
                //    if (char.IsUpper(index))
                //    {
                //        hasUpper = true;
                //    }
                //    else if (char.IsDigit(index))
                //    {
                //        hasDigit = true;
                //    }
                //}

                #region Foreach-le
                // for foreach den daha optimaldi cunki eger uppercase ve reqemi tapsaq loopu sona qeder getmeden bitire bilerik
                //foreach (char item in value)
                //{
                //    if (char.IsUpper(item))
                //    {
                //        hasUpper = true;
                //    }
                //    else if (char.IsDigit(item))
                //    {
                //        hasDigit = true;
                //    }
                //}
                #endregion

                //if (hasUpper && hasDigit)
                //{
                //    password = value;
                //}
                #endregion

                //else
                //{
                //    Console.WriteLine("Password needs to have at least 1 uppercase, 1 digit and more than 8 characters");
                //}
            }
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public virtual string GetAll()
        {
            return $"\nUsername: {Username}\nPassword: {Password}";
        }
       public static bool CheckIfTrue(string username,string password)
        {            
            if (username.Length > 6 && username.Length<30  && password.Any(char.IsDigit) && password.Any(char.IsUpper) && password.Length > 8)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }                    
    }
}
