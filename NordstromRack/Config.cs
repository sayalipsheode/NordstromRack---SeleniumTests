using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordstromRack
{
    public static class Config
    {
        public static string baseURL = "https://www.nordstromrack.com/";
        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "User1";
                public static string Password = "Username1";
                public static string RepeatPass = "user1";
                public static string BaseEmail = "sheode.sayali+1@gmail.com";
                //public static string Email = BaseEmail + Path.GetRandomFileName();
            }
        }
    }
}
