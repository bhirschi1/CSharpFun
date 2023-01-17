using System;

namespace CSharpFun // name of the program
{
    class Program 
    {
        // Start
        public static void Main(string[] args) // void is return type, string array named args are params
        {
            PrintStuff ps = new PrintStuff("PT"); //Instantiation; //Declaration
            string ?userName = "";

            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            

            ps.PrintName(userName);
        }

    }
}
