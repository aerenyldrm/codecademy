using System;

namespace AppInterfaces
{
    class Program
    {
        static void Main()
        {
            TodoList tl = new();
            tl.Add("Invite people"); tl.Add("Buy drink"); tl.Add("Party");
            tl.Display();

            PasswordManager pm = new("iluvpie", true);
            pm.ChangePassword("iluvpie", "ariferen");
            pm.Password = "nihansena";
            pm.Display();
        }
    }
}