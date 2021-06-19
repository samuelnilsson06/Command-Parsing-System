using System;
using CommandList;
using System.Reflection;

namespace CommandParsing
{
    class commandParse
    {
        public static void HandleInput(string _Input)
        {
            //Trim to get rid of unnecessary spaces
            _Input = _Input.Trim();

            string command = "";
            string[] arguments = new string[] { };


            try
            {
                //cut the command from input
                command = _Input.Substring(0, _Input.IndexOf(' '));
                //cut the arguments
                arguments = _Input.Substring(_Input.IndexOf(' ') + 1).Split(' ');
            }
            catch
            {
                Console.WriteLine("Invalid Input");
                Main.Program.TakeInput();
            }


            Console.WriteLine("\nCommand: {0}", command);

            // get all public static methods of MyClass type
            MethodInfo[] methodInfos = typeof(cmd).GetMethods();

            foreach (MethodInfo methodInfo in methodInfos)
            {
                if (methodInfo.Name == command)
                {
                    Console.WriteLine("the Command: {0} was found", methodInfo.Name);

                    // new instance to invoke
                    cmd t = new cmd();

                    // Inovke the instance
                    t.GetType().GetMethod(methodInfo.Name).Invoke(t, new[] { arguments });
                    Main.Program.TakeInput();
                }
                else
                {
                    Console.WriteLine("{0} was Checked and does not match: {1}", methodInfo.Name, command);
                }

            }
            Console.WriteLine("The command: {0} was not found", command);
            Main.Program.TakeInput();
        }
    }
}
