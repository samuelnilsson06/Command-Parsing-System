using System;
using CommandParsing;


namespace Main
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Command Parsing system";
            TakeInput();
        }
        public static void TakeInput()
        {
            string input = Console.ReadLine();

            commandParse.HandleInput(input);
        }
    }
}