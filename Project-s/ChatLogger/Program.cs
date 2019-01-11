using System;
using System.Collections.Generic;
using System.Linq;

namespace Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = new List<string>();
            while (true)
            {
                string []commands = Console.ReadLine().Split();
                if (commands[0] == "end")
                {
                    break;
                }
              
                switch (commands[0])
                {
                    case "Chat":
                        string message = commands[1];
                        command.Add(message);
                        break;
                    case "Delete":
                        string messageToDelete = commands[1];
                        for (int i = 0; i < command.Count; i++)
                        {
                            if (command[i] == messageToDelete)
                            {
                                command.Remove(messageToDelete);
                            }
                        }
                        
                        break;
                    case "Edit":
                        string messageToEdit = commands[1];
                        string editedVersion = commands[2];
                        for (int i = 0; i < command.Count; i++)
                        {
                            if (command[i] == messageToEdit)
                            {
                                command[i] = command[i].Replace(messageToEdit, editedVersion);
                            }
                        }
                       
                        break;
                    case "Pin":
                        for (int i = 0; i < command.Count; i++)
                        {
                            if (command[i] == commands[1])
                            {
                                command.Add(commands[1]);
                                command.Remove(commands[1]);
                                break;
                            }
                        }
                        break;
                    case "Spam":
                        for (int i = 1; i < commands.Length; i++)
                        {
                            command.Add(commands[i]);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join("\n",command));
           
        }
    }
}
