using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FortuneTeller
{
    class User
    {
        public  string FirstName { get; set; } 
        public  string LastName { get; set; }
        public  int Age { get; set; }
        public  int BirthMonth { get; set; }
        public  string FavoriteColor { get; set; }
        public  int NumberOfSiblings { get; set; }

        static User()
        {
        }

    }
}
