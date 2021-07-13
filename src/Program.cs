using System;
using command;


namespace Main
{
    class Program
    {
        static void Main()
        {
            TakeInput();
        }
        public static void TakeInput()
        {
            Console.Write(">");
            Use.command(Console.ReadLine());
        }
    }

}
