using System;

namespace art_app
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string x = Console.ReadLine();
            Console.WriteLine("What is your occupation?");
            string y = Console.ReadLine();
            var account = new member( x , y );
            Console.WriteLine($"A {account.occupation} member was created for {account.owner} ");
            bool repeatmenu = true;
            int token = account.token;
            while(repeatmenu)
            {
                repeatmenu = function.Menu(ref token);
            }
            account.token = token;
        }
    }
    
}


