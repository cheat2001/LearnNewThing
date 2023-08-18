namespace MulticastDelegate
{
    public class Program
    {
        delegate void MultiDelegate(string message);
        public static void Main(string[] args)
        {
            MultiDelegate multiDelegate = Method1;
            multiDelegate += Method2;
            multiDelegate += Method3;

            multiDelegate("Hello, Multicast Delegate!");

            Console.WriteLine("Removing Method2 from the delegate...");
            multiDelegate -= Method2;
            
            multiDelegate("After removing Method2");
        }

        static void Method1(string message)
        {
            Console.WriteLine("Method1: " + message);
        }

        static void Method2(string message)
        {
            Console.WriteLine("Method2: " + message);
        }

        static void Method3(string message)
        {
            Console.WriteLine("Method3: " + message);
        }
    }
}