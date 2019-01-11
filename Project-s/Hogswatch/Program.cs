using System;

namespace Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int numbersOfHomes = int.Parse(Console.ReadLine());
            int totalTakenPeresents = int.Parse(Console.ReadLine());
            int timesBack = 0;
            int additionalPresents = 0;
            int homeVisiter = 0;
            int remainingHomes = numbersOfHomes;
            int totalAddition = 0;
            int presentLeft = totalTakenPeresents;
            for (int i = 1; i <= numbersOfHomes; i++)
            {
                int numberOfSocks = int.Parse(Console.ReadLine());
                homeVisiter++;
                remainingHomes -= 1;
                if (presentLeft < numberOfSocks)
                {
                    additionalPresents = numberOfSocks - presentLeft;
                    timesBack++;
                    totalAddition += 
                        (int)(totalTakenPeresents / homeVisiter) * remainingHomes + additionalPresents;
                    presentLeft = (totalAddition - additionalPresents);
                }
                else
                {
                    presentLeft -= numberOfSocks;
                }

            }

            if (totalAddition <= 0 )
            {
                Console.WriteLine(presentLeft);
            }
            else
            {
                Console.WriteLine(timesBack);
                Console.WriteLine(totalAddition);
            }

        }
    }
}
