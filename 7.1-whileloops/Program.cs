namespace _7._1_whileloops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtherExample();
            Task2();
        }
        public static void Example()
        {
            while (true)
                Console.WriteLine("Are we there yet?");
        }
        public static void OtherExample()
        {
            int pin = 12345;
            int entry;
            Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            Console.Write("ENTER YOUR PIN: ");
            Int32.TryParse(Console.ReadLine(), out entry);
            Console.WriteLine();
            while (entry != pin)
            {
                Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
                Console.Write("ENTER YOUR PIN: ");
                Int32.TryParse(Console.ReadLine(), out entry);
                Console.WriteLine();
            }
            Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT. FUNDS ARE: -$1,000,000.00.");

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
                    Thread.Sleep(2000);
                }     
            }

            diceSum = diceResult + diceResult2;

            Console.WriteLine("Your dice are " + diceResult + " and " + diceResult2 + ".");

            Console.WriteLine("The sum is: " + diceSum + ".");
        }
    }
}