using System;

namespace CommandList
{
    class cmd
    {
        /*
        The command goes here
        You get the arguments packed in the string array args
        To run a command simly input the command followd by the args in console windows
        */
        public static void cmd1(string[] args)
        {
            Console.WriteLine(">>cmd1");
        }
        public static void cmd2(string[] args)
        {
            Console.WriteLine(">>cmd2");
        }
        public static void cmd3(string[] args)
        {
            Console.WriteLine(">>cmd3");
        }
    }
}