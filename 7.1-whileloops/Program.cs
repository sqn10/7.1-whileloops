namespace _7._1_whileloops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtherExample();
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
            Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");

            // it answers something conditional, boolean true and false.
            // 
        }
    }
}
