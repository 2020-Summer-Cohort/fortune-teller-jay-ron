using System;
using System.Runtime.CompilerServices;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Fortune Teller");
            StartGame();

        }

        static void StartGame()
        {
            User someUser = new User();
            GetUserInfo(someUser);
        }
        static void GetUserInfo(User someUser)
        {
            Console.WriteLine("What is your first name?");
            someUser.FirstName  = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            someUser.LastName = Console.ReadLine();

            Console.WriteLine("How old are you?");

            int usersAge = Convert.ToInt32(Console.ReadLine());
            someUser.SetAge(usersAge);
            Console.WriteLine("Your calculated retirement date is: " + someUser.RetirementDate.ToShortDateString());

            Console.WriteLine("Enter the integer to represent the month you were born:");
            someUser.BirthMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color?  Enter 'Help' if you don't know what ROYGBIV is.");
            someUser.FavoriteColor = Console.ReadLine();
            //loop

            Console.WriteLine("How many siblings do you have?");
            someUser.NumberOfSiblings = Convert.ToInt32(Console.ReadLine());

        }
    }
}
