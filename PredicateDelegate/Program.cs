namespace PredicateDelegate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Predicate<string> startsWithAPredicate = StartsWithA;
            bool startsWithA = startsWithAPredicate("Apple");

            Console.WriteLine("Does 'Apple' start with 'A'? " + startsWithA); 

        }

        static bool StartsWithA(string text)
        {
            return text.StartsWith("A");
        }
    }
}