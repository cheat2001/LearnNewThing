namespace ActionDelegate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Action<string> printMessage = Print;
            printMessage("Hello Bruh!");
        }
        static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}