namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Program");
            Console.WriteLine("Choose a VAlid Option From Below\n" +
                "1]: For User Name validation");
                
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    UserName.FirstName();
                    break;
                   
                default:
                    Console.WriteLine("Choose the valid option");
                    break;
            }
        }
    }
}
