namespace FuncDelegate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int, int> addFunc = Add;
            Func<int, string> MessageError = Error;

            int sum = addFunc(5, 3);
            string msg = MessageError(500);
            Console.WriteLine("Sum: "+ sum);
            Console.WriteLine("Message Error: " + msg);

        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static string Error(int code)
        {
            if (code == 404) return "Page not found!";
            else if (code == 500) return "Internal server error!";
            return "Application Crash!";
        }
    }
}