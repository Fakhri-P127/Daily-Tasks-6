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
                if (value.Length > 6)
                {
                    username = value;                        
                }
                else
                {
                    Console.WriteLine("Username needs to be longer than 6 letters");                                             
                }                                                             
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
            {//Linq den istifade etsem daha az kodla yazmaq olar
                bool hasUpper = false;  bool hasDigit = false;
                for (int i = 0; i < value.Length && !(hasUpper && hasDigit); i++)
                {
                    char index = value[i];
                    if (char.IsUpper(index))
                    {
                        hasUpper = true;
                    }
                    else if (char.IsDigit(index))
                    {
                        hasDigit = true;
                    }
                }
                #region Foreach-le
                //En optimal yolu for iledi cunki eger uppercase ve reqemi tapsaq loopu sona qeder getmeden bitire bilerik
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


                if (hasUpper && hasDigit)
                {                   
                    password = value;
                }
                else
                {
                    Console.WriteLine("Password needs to have at least 1 uppercase and 1 digit");
                }                
            }                                                     
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public virtual string GetAll()
        {
            return $"Username: {Username}\nPassword: {Password}";
        }
       public static bool isCorrect(string username, string password)
        {            
            if (username.Length > 6 && password.Any(char.IsDigit) && password.Any(char.IsUpper))
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
        //public bool Boolcheck(ref bool hasUpper, ref bool hasDigit)
        //{
        //    if(hasUpper && hasDigit)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        
    }
}
