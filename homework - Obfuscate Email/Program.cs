using System;

namespace homework___Obfuscate_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your email adress: ");
            string email = Console.ReadLine();

            int atPosition = email.IndexOf('@');
            if (atPosition > -1)
            {
                string newEmail = new string('*', atPosition) + email.Substring(atPosition);
                Console.WriteLine("Your email adress is " + newEmail);
            }

        }
    }
}
