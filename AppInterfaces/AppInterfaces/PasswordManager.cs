using System;

namespace AppInterface
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public string headerSymbol = "-------";
        public string HeaderSymbol
        {
            get
            {
                return headerSymbol;
            }
        }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }
        //Define a Display() method that: satisfies the interface requirements
        //uses Console.WriteLine() to print the actual password if Hidden is false. If Hidden is true, print asterisks*
        public void Display()
        {
            Console.WriteLine("\nPassword");
            Console.WriteLine(HeaderSymbol);
            if (!Hidden)
            {
                Console.WriteLine(Password);
            }
            else
            {
                Console.WriteLine("********");
            }
        }
        //Define a Reset() method to satisfy the interface. It should set Password to an empty string and set Hidden to false.
        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
    }
}