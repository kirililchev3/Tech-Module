using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_New_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> children = new Dictionary<string, int>();
            Dictionary<string, int> presents = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] data = input.Split("->");

                if (data.Length == 2)
                {
                    string names2 = data[1];
                    children.Remove(names2);
                    continue;

                }

                string names = data[0];
                string typeOfPresents = data[1];
                int amount = int.Parse(data[2]);

                if (!children.ContainsKey(names))
                {
                    children.Add(names, amount);
                }
                else
                {

                    children[names] += amount;
                }

                

                if (!presents.ContainsKey(typeOfPresents))
                {
                    presents.Add(typeOfPresents, amount);
                }
                else
                {
                    presents[typeOfPresents] += amount;
                }
            }
            Console.WriteLine("Children:");
            foreach (var kvp in children.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            Console.WriteLine("Presents:");
            foreach (var kvp in presents)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
            

            
        