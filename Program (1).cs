using System;

namespace LibraryAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine("Second price: " + prices[1]);
            Console.WriteLine();

            // Question 2
            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine("Copies on shelf 1, slot 0: " + shelfCopies[1, 0]);
            Console.WriteLine();

            // Question 3
            PrintWelcomeMessage();
            Console.WriteLine();

            // Question 4
            PrintBookTitle("Clean Code");
            Console.WriteLine();

            // Question 5
            int pages = 400;
            AddBonusPages(pages);
            // Prints 400 because int is passed by value (the method works on a copy)
            Console.WriteLine("Pages after AddBonusPages: " + pages);
            Console.WriteLine();

            // Question 6
            double[] discountPrices = { 25.5, 40.0 };
            ApplyDiscount(discountPrices);
            // Prints 20.5 because arrays are reference types (the method changes the same array)
            Console.WriteLine("prices[0] after ApplyDiscount: " + discountPrices[0]);
            Console.WriteLine();

            // Question 7
            AddBonusPagesByRef(ref pages);
            // Prints 450 because ref passes the original variable, not a copy
            Console.WriteLine("Pages after AddBonusPagesByRef: " + pages);
            Console.WriteLine();

            // Question 8
            ReplaceArray(ref prices);
            Console.WriteLine("prices.Length after ReplaceArray: " + prices.Length);
            Console.WriteLine();

            // Question 9
            if (TryGetPrice("Clean Code", out double foundPrice))
            {
                Console.WriteLine("Price found: " + foundPrice);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
            Console.WriteLine();

            // Question 10
            PrintBookInfo("Clean Code");
            PrintBookInfo("Clean Code", 464);
            Console.WriteLine();

            // Question 11
            PrintBookInfo(pages: 250, title: "The Pragmatic Programmer");
            Console.WriteLine();

            // Question 12
            PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Refactoring");

            Console.ReadLine();
        }

        // Question 3
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        // Question 4
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        // Question 5
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        // Question 6
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        // Question 7
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        // Question 8
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        // Question 9
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }

            price = 0;
            return false;
        }

        // Question 10
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Title: " + title + ", Pages: " + pages);
        }

        // Question 12
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string t in titles)
            {
                Console.WriteLine(t);
            }
        }
    }
}
