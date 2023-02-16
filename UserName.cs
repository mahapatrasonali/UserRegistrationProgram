using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserName
    {
        public static void EmailValidating()      //UC3
        {
            Console.WriteLine("Enter your EmailId");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-z]{3,7}.?[a-z0-9]{3,8}@[a-z]{3,8}.(com|org)$";
            Iteration(userInput, regexCondition);
        }

        public static void Iteration(string userInput, string regexCondition)
        {
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
            }
        }
    }
}
