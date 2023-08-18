namespace SingleDelegate
{
    public class Program
    {
        delegate void HelloWorld(string message);
        public static void Main(string[] args)
        {
            HelloWorld helloWorld = DisplayMessage;
            DisplayMessage("Hello World");
        }

        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}