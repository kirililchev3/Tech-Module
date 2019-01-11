using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int santaPosition = 0;

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split();
                switch (commands[0])
                {
                    case "Forward":
                        int indexToForward = int.Parse(commands[1]);
                        if (santaPosition >= 0 && santaPosition <= numbers.Count)
                        {
                            if (indexToForward + santaPosition < numbers.Count)
                            {
                                santaPosition += indexToForward;
                                numbers.RemoveAt(santaPosition);
                            }
                            
                        }
                        break;
                    case "Back":
                        int indexToBack = int.Parse(commands[1]);

                        if (santaPosition > 0 && santaPosition <= numbers.Count)
                        {
                            if (indexToBack <= santaPosition)
                            {
                                santaPosition -= indexToBack;
                                numbers.RemoveAt(santaPosition);
                            }
                            
                        }
                        break;
                    case "Gift":
                        int indexToInsert = int.Parse(commands[1]);
                        int numberToInsert = int.Parse(commands[2]);
                        if (indexToInsert <= numbers.Count)
                        {
                            numbers.Insert(indexToInsert, numberToInsert);
                            santaPosition = indexToInsert;
                        }
                        break;
                    case "Swap":
                        int number1 = int.Parse(commands[1]);
                        int number2 = int.Parse(commands[2]);
                        if (numbers.Contains(number1) && numbers.Contains(number2))
                        {
                            int firstIndex = numbers.IndexOf(number1);
                            int secondIndex = numbers.IndexOf(number2);
                            numbers[firstIndex] = number2;
                            numbers[secondIndex] = number1;
                        }
                        break;
                }

            }
            Console.WriteLine($"Position: {santaPosition}");
            Console.WriteLine(String.Join(", ", numbers));
        }


    }
}