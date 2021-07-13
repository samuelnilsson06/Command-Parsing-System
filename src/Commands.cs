using System;
using System.Reflection;

namespace command
{
    class Use
    {
        public static void command(string _Input)
        {
            //Trim to get rid of unnecessary spaces
            _Input = _Input.Trim();

            string command = "";
            string[] arguments = new string[] { string.Empty };

            if (_Input.Contains(" "))
            {
                //cut the command from input
                command = _Input.Substring(0, _Input.IndexOf(' '));
                //cut the arguments
                arguments = _Input.Substring(_Input.IndexOf(' ') + 1).Split(' ');
            }
            else
            {
                command = _Input;
            }


            // get all public static methods of the cmd class
            MethodInfo[] methodInfos = typeof(cmd).GetMethods();

            foreach (MethodInfo methodInfo in methodInfos)
            {
                if (methodInfo.Name == command)
                {

                    // new instance to invoke
                    cmd cmd = new cmd();

                    // Inovke the instance
                    cmd.GetType().GetMethod(methodInfo.Name).Invoke(cmd, new[] { arguments });
                    Main.Program.TakeInput();
                }

            }
            Console.WriteLine("The command: {0} was not found", command);
            Main.Program.TakeInput();
        }
    }
    class cmd
    {
        /*
        The command goes here
        You get the arguments packed in the string array args
        To run a command by simply inputing the command followd by the args in console windows
        */

        public static void cmd1(string[] args)
        {
            Console.WriteLine("cmd1");
        }
        public static void cmd2(string[] args)
        {
            Console.WriteLine("cmd2");
        }
        public static void cmd3(string[] args)
        {
            Console.WriteLine("cmd3");
        }
    }
}
