// System namespace needed to use Console class.
using System;

// My collection of classes for this project.
namespace Methods_Sadler_Madison
{
    // Main class for the program
    class Program
    {
        // The Main method is executed when the application starts
        static void Main(string[] args)
        {
            // Asks the user to enter a whole number
            Console.WriteLine("User, please enter a whole number.");
            // Gives user input and converts input to integer under the integer x
            int x = Convert.ToInt32(Console.ReadLine());
            // Asks the user to enter another whole number
            Console.WriteLine("User, please enter another whole number.");
            // Gives user input and converts input to integer under the integer y
            int y = Convert.ToInt32(Console.ReadLine());

            // Prints to the console what the product of x and y is
            Console.WriteLine(Multiply(x, y));

            // Asks the user what their name is
            Console.WriteLine("What is your name, user?");
            // Gives user input under the string name
            string name = Console.ReadLine();

            // States a method called WelcomeUser with the string name
            WelcomeUser(name);

            // States a method called GoodbyeUser
            GoodbyeUser();
        }

        // Runs method Multiply with two integers, num1 and num2
        static int Multiply(int num1, int num2)
        {
            // Returns num1 times num2
            return num1 * num2;
        }

        // Runs method WelcomeUser
        static void WelcomeUser(string username)
        {
            //Prints to console a welcome to the user
            Console.WriteLine($"Hello, {username}! It is nice to meet you! Even though I am a program and have no emotions, I can still say it's nice to meet someone, right?");
        }

        // Runs method GoodbyeUser
        static void GoodbyeUser()
        {
            // Prints to console a goodbye to the user
            Console.WriteLine("Goodbye, user. Have a fantastic day! I don't know what a fantastic day would be to you, but I hope you have that, whatever it may be.");
        }
    }
}
