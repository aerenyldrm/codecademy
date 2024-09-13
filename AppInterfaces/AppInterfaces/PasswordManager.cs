using System;

namespace AppInterfaces
{
    class PasswordManager : IDisplayable, IResetable
    {
        // IDisplayable interface property
        public string HeaderSymbol { get; set; }

        // IDisplayable interface method
        public void Display()
        {
            Console.WriteLine("PASSWORD:");
            Console.WriteLine(HeaderSymbol);

            if (Password != "")
            {
                if (Hidden == false)
                    Console.WriteLine(Password);
                else
                {
                    for (int i = 0; i < Password.Length; i++)
                        Console.Write('*');

                    Console.WriteLine(); // line restart
                }
            }

            Console.WriteLine(); // line break
        }

        // IResetable interface method
        public void Reset()
        {
            Password = "";
            Hidden = false;
        }

        // field
        private string password;

        // instance property
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 8)
                { password = value; }
            }
        }
        public bool Hidden { get; private set; }

        // constructor
        public PasswordManager(string password, bool hidden)
        {
            this.password = password;
            Hidden = hidden;
            HeaderSymbol = "----------";
        }

        // method
        public bool ChangePassword(string old, string update)
        {
            if (old == Password)
            {
                Password = update;
                return true;
            }
            else
                return false;
        }
    }
}