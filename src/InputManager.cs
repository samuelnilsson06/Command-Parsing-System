using System;

namespace InputSystem
{
    class InputManager
    {
        public static void TakeInput()
        {
            Console.Write($"{Environment.UserName}>");
            string inpt = Console.ReadLine();
            InputManager.Handle(inpt);
        }
        public static void Handle(string Inpt)
        {
            Inpt = Inpt.Trim();
            if (Inpt == "")
            {
                Console.WriteLine("No Input was given");
            }

            string cmd;
            try
            {
                cmd = Inpt.Substring(0, Inpt.IndexOf(' '));
            }
            catch
            {
                cmd = Inpt;
            }

            
            if (typeof(Commands.cmd).GetMethod(cmd) != null)
            {
                // Does command contain arguments (Cant be "[the cmd][space]" because of Trim())
                if (Inpt.Contains(" "))
                {
                    string[] args = Inpt.Substring(Inpt.IndexOf(' ') + 1).Split(' ');

                    //Get the mothod name of cmds, then create new instance and pass it the argument
                    typeof(Commands.cmd).GetMethod(cmd).Invoke(new Commands.cmd(), new[] { args });
                }
                else
                {
                    //else pass it an empty string in the array
                    typeof(Commands.cmd).GetMethod(Inpt).Invoke(new Commands.cmd(), new[] { new string[] { "" } });
                }
                
            }
            else
            {
                Console.WriteLine("command not found");
            }
        }
    }
    
}
