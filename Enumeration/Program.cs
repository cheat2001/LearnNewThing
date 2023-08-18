namespace Enumeration
{
    public class Program
    {
       
        public static void Main(string[] args)
        {

            HttpStatusCode statusCode = HttpStatusCode.NotFound;

            if(statusCode == HttpStatusCode.NotFound)
            {
                Console.WriteLine("Data is not found!");
            }
            else if(statusCode == HttpStatusCode.Unauthorized)
            {
                Console.WriteLine("Unauthorized user!");
            }
            else if(statusCode == HttpStatusCode.Ok)
            {
                Console.WriteLine("All good!");
            }
            else
            {
                Console.WriteLine("Internal Server Error!");
            }


            RoleUser user = RoleUser.Admin;
            if(user == RoleUser.Admin)
            {
                Console.WriteLine("Can edit picture!");
            }
            else
            {
                Console.WriteLine("Sorry! you can only view!");
            }


        }
    }
}