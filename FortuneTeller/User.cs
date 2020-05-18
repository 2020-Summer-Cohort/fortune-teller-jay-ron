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
        public  int Age { get; private set; }

        public DateTime RetirementDate { get; private set; }
        public  int BirthMonth { get; set; }
        public  string FavoriteColor { get; set; }
        public  int NumberOfSiblings { get; set; }

        static User()
        {
        }

        public void SetAge(int age)
        {

            this.Age = age;
            bool isEven = (this.Age % 2 == 0);
            if (isEven)
                this.RetirementDate = DateTime.Now.AddYears(10);

            else
                this.RetirementDate = DateTime.Now.AddYears(11);

        }

    }
}
