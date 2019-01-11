using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, string> parking = new Dictionary<string, string>();
            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)

            {
                string inputLine = Console.ReadLine();
                var commands = inputLine.Split().ToArray();
                string command = commands[0];
                string userName = commands[1];
                
                if (command == "register")
                {
                    string licenseNumber = commands[2].ToUpper();
                    
                    if (parking.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[userName]}");
                        
                    }
                    else if (!parking.ContainsKey(userName))
                    {
                        parking.Add(userName, licenseNumber);
                        Console.WriteLine($"{userName} registered {licenseNumber} successfully");
                    }

                }
                else if (command == "unregister")
                {
                    if (!parking.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                        
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        parking.Remove(userName);
                    }
                    
                    
                }
               
            }
            foreach (var plate in parking)
            {
                Console.WriteLine($"{plate.Key} => {plate.Value}");
            }
        }

        
    }
}
