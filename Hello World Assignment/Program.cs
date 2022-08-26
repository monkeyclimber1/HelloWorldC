namespace Hello_World_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string stg = "Hello,World!";
            Console.WriteLine(stg);

            Console.WriteLine("Enter Username");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter User's Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Username Is: " + userName + " And The Age Is " + age );
        }
        
    }
}