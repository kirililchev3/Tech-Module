using System;

namespace Santa_s_Cookies
{
    class Program
    {
        /* Item	Grams
            Single cookie Grams 	25
            Cup	140
            Small Spoon	10
            Big Spoon	20
            Cookies per Box	5
            */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int singleCookieGrams = 25;
            int smallSpooon = 10;
            int bigSpoon = 20;
            int cup = 140;
            int cookiesPerBox = 5;
            int boxesPerBatch = 0;
            decimal totalCookiesPerBake = 0;
            int totalCookieBox = 0;
            int min = 0;




            for (int i = 0; i < n; i++)
            {
                int flour = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                int cocoa = int.Parse(Console.ReadLine());
                int flourCups = flour / cup;
                int sugarSpoon = sugar / bigSpoon;
                int cocoaSpoon = cocoa / smallSpooon;

                min = Math.Min(flourCups, Math.Min(sugarSpoon, cocoaSpoon));

                totalCookiesPerBake = Math.Floor(170m * min/singleCookieGrams);
                boxesPerBatch = (int)totalCookiesPerBake / cookiesPerBox;
                if (flourCups <= 0 || sugarSpoon <= 0 || cocoaSpoon <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    Console.WriteLine($"Boxes of cookies: {boxesPerBatch}");
                }
                totalCookieBox += boxesPerBatch;
            }
            Console.WriteLine($"Total boxes: {totalCookieBox}");
        }
    }
}
