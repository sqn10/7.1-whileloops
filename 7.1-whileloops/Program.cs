using System;

namespace _7._1_whileloops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtherExample();
            Task2();
            AnotherMethod();
        }
        public static void Example()
        {
            while (true)
                Console.WriteLine("Are we there yet?");
        }
        public static void OtherExample()
        {
            bool done = false; // We can set this to ‘true’ to end the loop
            int entry = 12345, tries = 0, pin = 0;
            Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            while (!done)
            {
                Console.WriteLine("ENTER YOUR PIN: ");
                while (!Int32.TryParse(Console.ReadLine(), out pin))
                    Console.WriteLine("Please enter a valid number");
                tries++;
                if (pin == entry)
                {
                    Console.WriteLine("Pin Accepted.");
                    done = true; // This ends the loop
                }
                else if (tries == 5)
                {
                    Console.WriteLine("Too many incorrect tries. Access denied");
                    done = true; // This ends the loop
                }
            }

            // it answers something conditional, boolean true and false.
            // it's a loop and an if statement isn't. it will keep running until something is what you want it to be.
            /* It keeps looping the printed text over and over again. The first time the pin works fine because it's not in the loop,
             * but when it's in the loop, entry will never equal pin (always NOT equal pin) so it'll just keep looping. The computer
             * can never have the "right" data in the entry variable.
             */
        }
        public static void Task2()
        {
            int diceResult = 0, diceResult2 = 0, diceSum = 0;

            Random generator = new Random();

            Console.WriteLine();
            Console.WriteLine("This program will only finish when it rolls two of the same dice.");
            Console.WriteLine();

            bool done = false;
            while(!done)
            {
                diceResult = generator.Next(1, 7);
                diceResult2 = generator.Next(1, 7);

                if (diceResult == diceResult2)
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("Currently " + diceResult + " and " + diceResult2 + ".");
                    Thread.Sleep(800);
                }     
            }

            diceSum = diceResult + diceResult2;

            Console.WriteLine("Your dice are " + diceResult + " and " + diceResult2 + ".");

            Console.WriteLine("The sum is: " + diceSum + ".");
        }
        public static void AnotherMethod()
        {
            int count = 0; // This will count the number of times we have looped
            Console.WriteLine("Type in a message, and I'll display it 5 times.");
            Console.Write("Message: ");
            string message = Console.ReadLine();
            while (count < 5)
            {
                Console.WriteLine((count + 1) + ". " + message);
                count++; // Adds 1 to our counter
            }
        }
    }
}