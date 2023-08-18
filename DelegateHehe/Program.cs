namespace DelegateHehe
{
    public class Program
    {
        public delegate void Callback(string message);
        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        public static void Main(string[] args)
        {
            // Instantiate the delegate.
            Callback handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");
        }
    }
}